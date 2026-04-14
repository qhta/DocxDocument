using System.Diagnostics.CodeAnalysis;

using Qhta.Collections;

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

/// <summary>
/// Adds <c>[OpenXmlProperty]</c> attributes to model classes backed by Open XML elements.
/// </summary>
public static class AddOpenXmlPropertyAttribute
{
  /// <summary>
  /// Rewrites the specified file, annotating properties that map to Open XML members.
  /// </summary>
  /// <param name="filePath">Absolute or relative path to the C# file to update.</param>
  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetCompilationUnitRoot();

    var aliasMap = AliasHelper.BuildAliasMap(filePath, root);
    try
    {
      var rewriter = new AddOpenXmlPropertyAttributeRewriter(aliasMap);
      var newRoot = rewriter.Visit(root);

      if (rewriter.Changed)
      {
        File.WriteAllText(filePath, newRoot.NormalizeWhitespace(" ").ToFullString());
        Console.WriteLine($"Updated: {filePath}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error processing {filePath}\n {ex.Message}");
      throw;
    }
  }
}

/// <summary>
/// Roslyn rewriter that injects <c>[OpenXmlProperty]</c> attributes for <c>ModelElement&lt;TOpenXml&gt;</c> classes.
/// </summary>
/// <param name="aliasMap">Namespace alias map extracted from the processed file.</param>
public class AddOpenXmlPropertyAttributeRewriter(BiDiDictionary<string, string> aliasMap) : CSharpSyntaxRewriter
{
  public bool Changed { get; private set; } = false;

  /// <summary>
  /// Adds missing <c>[OpenXmlProperty]</c> attributes to properties when the backing Open XML member exists.
  /// </summary>
  /// <param name="classNode">Class declaration to inspect.</param>
  /// <returns>Updated class syntax node or original when unchanged.</returns>
  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax classNode)
  {

    // Skip abstract classes
    //if (classNode.Modifiers.Any(m => m.IsKind(SyntaxKind.AbstractKeyword)))
    //  return classNode;

    var openXmlTypeAttribute = classNode.AttributeLists
      .SelectMany(selector: al => al.Attributes)
      .FirstOrDefault(predicate: attr =>
      {
        var attrName = attr.Name.ToString();
        return attrName == "OpenXmlType";
      });

    if (openXmlTypeAttribute?.ArgumentList == null) 
      return base.VisitClassDeclaration(node: classNode);

    if (openXmlTypeAttribute.ArgumentList.Arguments.Count < 1)
      return base.VisitClassDeclaration(node: classNode);

    var openXmlTypeExpression = openXmlTypeAttribute.ArgumentList.Arguments[index: 0].Expression;
    if (openXmlTypeExpression is not TypeOfExpressionSyntax typeOfExpression)
      return base.VisitClassDeclaration(node: classNode);

    var openXmlTypeName =  typeOfExpression.Type.ToString();
    if (!TryResolveOpenXmlType(ResolveAlias(openXmlTypeName), out var openXmlType))
      return base.VisitClassDeclaration(node: classNode);


    // Add [OpenXmlProperty(nameof(Format.EnumPropertyName))] to each property

    var newMembers = new List<MemberDeclarationSyntax>();
    foreach (var member in classNode.Members)
    {
      if (member is not PropertyDeclarationSyntax prop)
      {
        newMembers.Add(member);
        continue;
      }

      // Only touch properties that have a setter
      var hasSetter = prop.AccessorList?.Accessors.Any(predicate: a => a.Kind() == SyntaxKind.SetAccessorDeclaration) ==
                      true;
      if (!hasSetter)
      {
        newMembers.Add(prop);
        continue;
      }
      var hasAttr = prop.AttributeLists.SelectMany(selector: al => al.Attributes)
        .Any(predicate: attr => attr.Name.ToString().Contains(value: "OpenXmlProperty"));
      if (hasAttr)
      {
        newMembers.Add(prop);
        continue;
      }

      var leadingTrivia = prop.GetLeadingTrivia();
      var docTrivia = leadingTrivia.Where(predicate: t =>
        t.IsKind(kind: SyntaxKind.SingleLineDocumentationCommentTrivia) ||
        t.IsKind(kind: SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
      var otherTrivia = leadingTrivia.Except(second: docTrivia).ToList();

      if (!PropertyExistsInOpenXmlType(openXmlType!, prop.Identifier.Text))
      {
        newMembers.Add(prop);
        continue;
      }
      var attributeName = "OpenXmlProperty";

      var attr = SyntaxFactory.Attribute(name: SyntaxFactory.IdentifierName(name: attributeName),
        argumentList: SyntaxFactory.AttributeArgumentList(arguments: SyntaxFactory.SingletonSeparatedList(
          node: SyntaxFactory.AttributeArgument(
            expression: SyntaxFactory.ParseExpression(text: $"nameof({openXmlTypeName}.{prop.Identifier.Text})")))));

      var attrList = SyntaxFactory.AttributeList(attributes: SyntaxFactory.SingletonSeparatedList(node: attr))
        .WithLeadingTrivia(trivia: SyntaxFactory.TriviaList(trivias: docTrivia));
      var newProp = prop.WithLeadingTrivia(trivia: SyntaxFactory.TriviaList(trivias: otherTrivia))
        .WithAttributeLists(attributeLists: prop.AttributeLists.Add(node: attrList))
        .WithTrailingTrivia(trivia: prop.GetTrailingTrivia());

      Changed = true;
      newMembers.Add(newProp);
    }
    return classNode.WithMembers(members: SyntaxFactory.List(nodes: newMembers));
  }

  /// <summary>
  /// Determines whether the Open XML type already declares a property with the specified name.
  /// </summary>
  /// <param name="openXmlType">Open XML type name.</param>
  /// <param name="propertyName">Property to look up.</param>
  private bool PropertyExistsInOpenXmlType(Type openXmlType, string propertyName)
  {
    return openXmlType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase) != null;
  }

  /// <summary>
  /// Resolves a type name using alias expansion and cached Open XML assemblies.
  /// </summary>
  /// <param name="typeName">Candidate type name.</param>
  /// <param name="type">Resolved <see cref="Type"/> when successful.</param>
  /// <returns><see langword="true"/> if the type could be resolved.</returns>
  private bool TryResolveOpenXmlType(string typeName, out Type? type)
  {
    if (TypeCache.TryResolveType(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }

    var resolvedName = ResolveAlias(typeName);
    type = TypeCache.ResolveType(resolvedName);
;
    return type!=null;
  }

  /// <summary>
  /// Expands namespace aliases referenced within the current file.
  /// </summary>
  /// <param name="typeName">Type name potentially prefixed with an alias.</param>
  private string ResolveAlias(string typeName)
  {
    var dotIndex = typeName.IndexOf('.');
    if (dotIndex > 0)
    {
      var alias = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue(alias, out var ns))
        return ns + "." + typeName.Substring(dotIndex + 1);
    }
    return typeName;
  }
}