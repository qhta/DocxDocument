namespace AutoEdit;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DocumentFormat.OpenXml;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class AddOpenXmlElementAttribute
{
  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetCompilationUnitRoot();

    var aliasMap = AliasHelper.BuildAliasMap(filePath, root);
    var rewriter = new AddOpenXmlElementAttributeRewriter(aliasMap);
    var newRoot = rewriter.Visit(root);

    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace("  ").ToFullString());
      Console.WriteLine($"Updated: {filePath}");
    }
  }
}

public class AddOpenXmlElementAttributeRewriter(Dictionary<string, string> aliasMap) : CSharpSyntaxRewriter
{
  private readonly Dictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  private static readonly Assembly? OpenXmlAssembly = typeof(OpenXmlElement).Assembly;

  public bool Changed { get; private set; } = false;

  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
  {
    if (node.Modifiers.Any(m => m.IsKind(SyntaxKind.AbstractKeyword)))
      return node;

    var baseType = node.BaseList?.Types
        .Select(bt => bt.Type)
        .OfType<GenericNameSyntax>()
        .FirstOrDefault(g => g.Identifier.Text == "ModelElement");

    if (baseType == null)
      return base.VisitClassDeclaration(node);

    var openXmlType = baseType.TypeArgumentList.Arguments.First().ToString();

    var newMembers = node.Members.Select(member =>
    {
      if (member is PropertyDeclarationSyntax prop)
      {
        var hasSetter = prop.AccessorList?.Accessors
          .Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration) == true;
        if (!hasSetter)
          return member;

        var hasElementAttr = prop.AttributeLists
          .SelectMany(al => al.Attributes)
          .Any(attr => attr.Name.ToString().Contains("OpenXmlElement"));

        if (hasElementAttr)
          return member;

        if (PropertyExistsInOpenXmlType(openXmlType, prop.Identifier.Text))
          return member;

        var leadingTrivia = prop.GetLeadingTrivia();
        var docTrivia = leadingTrivia.Where(t =>
            t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) ||
            t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia))
          .ToList();
        var otherTrivia = leadingTrivia.Except(docTrivia).ToList();

        var attr = SyntaxFactory.Attribute(
          SyntaxFactory.IdentifierName("OpenXmlElement"),
          SyntaxFactory.AttributeArgumentList(
            SyntaxFactory.SingletonSeparatedList(
              SyntaxFactory.AttributeArgument(
                SyntaxFactory.TypeOfExpression(
                  SyntaxFactory.ParseTypeName(openXmlType))
              ))));

        var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr))
          .WithLeadingTrivia(SyntaxFactory.TriviaList(docTrivia));
        var newProp = prop
          .WithLeadingTrivia(SyntaxFactory.TriviaList(otherTrivia))
          .WithAttributeLists(prop.AttributeLists.Add(attrList))
          .WithTrailingTrivia(prop.GetTrailingTrivia());

        Changed = true;
        return newProp;
      }
      return member;
    }).ToList();

    return node.WithMembers(SyntaxFactory.List(newMembers));
  }

  private bool PropertyExistsInOpenXmlType(string openXmlTypeName, string propertyName)
  {
    if (!TryResolveOpenXmlType(openXmlTypeName, out var type))
      return false;

    return type!.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase) != null;
  }

  private bool TryResolveOpenXmlType(string typeName, out Type? type)
  {
    if (_typeCache.TryGetValue(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }

    var resolvedName = ResolveAlias(typeName);
    type = Type.GetType(resolvedName, throwOnError: false, ignoreCase: false) ??
            OpenXmlAssembly?.GetType(resolvedName, throwOnError: false, ignoreCase: false);

    if (type == null)
    {
      foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
      {
        type = asm.GetType(resolvedName, false, false);
        if (type != null)
          break;
      }
    }

    _typeCache[typeName] = type;
    return type != null;
  }

  private string ResolveAlias(string typeName)
  {
    var dotIndex = typeName.IndexOf('.');
    if (dotIndex > 0)
    {
      var alias = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue(alias, out var ns))
        return ns + "." + typeName[(dotIndex + 1)..];
    }
    return typeName;
  }
}
