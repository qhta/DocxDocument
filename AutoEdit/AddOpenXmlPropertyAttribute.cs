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
public class AddOpenXmlPropertyAttributeRewriter(Dictionary<string, string> aliasMap) : CSharpSyntaxRewriter
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

    // Check if class inherits from ModelElement<T>
    var baseTypeNode = classNode.BaseList?.Types
        .Select(bt => bt.Type)
        .OfType<GenericNameSyntax>()
        .FirstOrDefault(g => g.Identifier.Text == "ModelElement");

    if (baseTypeNode == null)
      return base.VisitClassDeclaration(classNode);

    // Get the type parameter (OpenXml type)
    var argumentTypeNode = baseTypeNode.TypeArgumentList.Arguments.First();
    var openXmlTypeName = argumentTypeNode.ToString();
    if (openXmlTypeName == "T")
    {
      var typeParamClause = classNode.ConstraintClauses.FirstOrDefault(clause => clause.Name.Identifier.Text == openXmlTypeName);
      if (typeParamClause?.Constraints == null)
        return base.VisitClassDeclaration(classNode);

      var constraint = typeParamClause.Constraints.OfType<TypeConstraintSyntax>().FirstOrDefault();
      if (constraint == null)
        return base.VisitClassDeclaration(classNode);

      var qualifiedName = constraint.Type is QualifiedNameSyntax constraintType ? constraintType.ToString() : constraint.Type.ToString();
      if (qualifiedName == "DX.OpenXmlElement")
        return base.VisitClassDeclaration(classNode);

      openXmlTypeName = qualifiedName;
    }
    // Add [OpenXmlProperty(nameof(Format.EnumPropertyName))] to each property
    var newMembers = classNode.Members.Select(member =>
    {
      if (member is PropertyDeclarationSyntax prop)
      {
        // Only touch properties that have a setter
        var hasSetter = prop.AccessorList?.Accessors
          .Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration) == true;
        if (!hasSetter)
          return member;

        var hasAttr = prop.AttributeLists
          .SelectMany(al => al.Attributes)
          .Any(attr => attr.Name.ToString().Contains("OpenXmlProperty"));

        if (!hasAttr)
        {
          var leadingTrivia = prop.GetLeadingTrivia();
          var docTrivia = leadingTrivia.Where(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
          var otherTrivia = leadingTrivia.Except(docTrivia).ToList();

          if (PropertyExistsInOpenXmlType(openXmlTypeName, prop.Identifier.Text))
          {
            var attributeName = "OpenXmlProperty";

            var attr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName(attributeName), 
              SyntaxFactory.AttributeArgumentList(SyntaxFactory.SingletonSeparatedList
                (SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression($"nameof({openXmlTypeName}.{prop.Identifier.Text})")))));

            var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr))
              .WithLeadingTrivia(SyntaxFactory.TriviaList(docTrivia));
            var newProp = prop.WithLeadingTrivia(SyntaxFactory.TriviaList(otherTrivia))
              .WithAttributeLists(prop.AttributeLists.Add(attrList)).WithTrailingTrivia(prop.GetTrailingTrivia());

            Changed = true;
            return newProp;
          }
        }
      }
      return member;
    }).ToList();
    return classNode.WithMembers(SyntaxFactory.List(newMembers));
  }

  /// <summary>
  /// Determines whether the Open XML type already declares a property with the specified name.
  /// </summary>
  /// <param name="openXmlTypeName">Fully-qualified Open XML type name.</param>
  /// <param name="propertyName">Property to look up.</param>
  private bool PropertyExistsInOpenXmlType(string openXmlTypeName, string propertyName)
  {
    if (!TryResolveOpenXmlType(openXmlTypeName, out var type))
      return false;

    return type!.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase) != null;
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
    //{
    //  foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
    //  {
    //    type = asm.GetType(resolvedName, false, false);
    //    if (type != null)
    //      break;
    //  }
    //}

    //_typeCache[typeName] = type;
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
        return ns + "." + typeName[(dotIndex + 1)..];
    }
    return typeName;
  }
}