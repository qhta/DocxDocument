using System.Diagnostics;

using DocumentFormat.OpenXml.Drawing;

namespace AutoEdit;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>
/// Automates annotating enum declarations with Open XML helper attributes.
/// </summary>
public static class AddOpenXmlEnumTypeAttribute
{
  /// <summary>
  /// Rewrites the specified source file, inserting Open XML metadata attributes where needed.
  /// </summary>
  /// <param name="filePath">Absolute or relative path to the C# file to update.</param>
  public static bool Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetCompilationUnitRoot();
    var aliasMap = AliasHelper.BuildAliasMap(filePath, root);
    var rewriter = new AddOpenXmlEnumTypeAttributeRewriter(aliasMap);
    var newRoot = rewriter.Visit(root);
    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace("  ").ToFullString());
      Console.WriteLine($"Updated: {filePath}");
      return true;
    }
    return false;
  }
}

/// <summary>
/// Roslyn syntax rewriter that augments enums and members with Format/OpenXmlEnumElement attributes.
/// </summary>
/// <param name="aliasMap">Namespace aliases detected within the file being processed.</param>
public class AddOpenXmlEnumTypeAttributeRewriter(Dictionary<string, string> aliasMap): CSharpSyntaxRewriter
{
  private readonly Dictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  private static readonly Assembly? OpenXmlFrameworkAssembly = typeof(OpenXmlElement).Assembly;
  private static readonly Assembly? OpenXmlAssembly = typeof(Document).Assembly;

  /// <summary>
  /// Indicates when the rewriter produced updated syntax.
  /// </summary>
  public bool Changed { get; private set; } = false;

  /// <summary>
  /// Updates enum declarations by injecting missing OpenXml metadata and returns the resulting syntax node.
  /// </summary>
  /// <param name="node">Enum declaration currently being visited.</param>
  /// <returns>The original node when no changes were required, otherwise the updated declaration.</returns>
  public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
  {
    List<string> enumTypeNameCandidates = new();
    string? enumTypeName = null;
    if (node.AttributeLists.SelectMany(al => al.Attributes)
          .FirstOrDefault(attr => attr.Name.ToString().Contains("Format", StringComparison.Ordinal)) != null)
    {
      Console.WriteLine(node.Identifier.Text);
      return base.VisitEnumDeclaration(node);
    }
    if (node.AttributeLists.SelectMany(al => al.Attributes)
          .FirstOrDefault(attr => attr.Name.ToString().Contains("OpenXmlNotMapped", StringComparison.Ordinal)) != null)
      return base.VisitEnumDeclaration(node);

    AttributeSyntax? enumTypeAttribute = node.AttributeLists.SelectMany(al => al.Attributes)
      .FirstOrDefault(attr =>
        attr.Name.ToString().Contains("OpenXmlEnumType", StringComparison.Ordinal));
    var hasOpenXmlEnumTypeAttribute = enumTypeAttribute != null;
    if (enumTypeAttribute != null)
    {
      var argument = enumTypeAttribute.ArgumentList?.Arguments.FirstOrDefault();
      if (argument?.Expression is TypeOfExpressionSyntax typeOfExpressionSyntax)
        enumTypeNameCandidates.Add(typeOfExpressionSyntax.Type.ToString());
      else
        enumTypeNameCandidates.Add(argument!.Expression!.ToString());
    }
    else
    {
      enumTypeName = node.Identifier.Text;
      if (enumTypeName.EndsWith("Type"))
        enumTypeName = enumTypeName.Substring(0, enumTypeName.Length - 4);
      enumTypeNameCandidates.Add(enumTypeName + "Values");
      enumTypeNameCandidates.Add(enumTypeName + "TypeValues");
      enumTypeNameCandidates.Add(enumTypeName + "Type");
      enumTypeNameCandidates.Add(enumTypeName + "Enum");
      enumTypeNameCandidates.Add(enumTypeName);
    }

    Type? openXmlEnumType = null;
    foreach (var enumTypeNameCandidate in enumTypeNameCandidates)
    {
      if (TryResolveOpenXmlType(enumTypeNameCandidate, out openXmlEnumType) && openXmlEnumType != null)
      {
        enumTypeName = enumTypeNameCandidate;
        break;
      }
    }
    if (openXmlEnumType == null)
    {
      Console.WriteLine($"Failed to resolve Open XML enum type for {enumTypeName}");
      return base.VisitEnumDeclaration(node);
    }    
    var isEnumValueType = openXmlEnumType.GetInterface("IEnumValue") != null;
    if (!openXmlEnumType.IsEnum && !isEnumValueType)
    {
      Console.WriteLine($"Resolved Open XML type {openXmlEnumType.FullName} is not an enum nor EnumValue type.");
      return base.VisitEnumDeclaration(node);
    }
    var enumValues = (isEnumValueType)
      ? openXmlEnumType.GetProperties(BindingFlags.Static | BindingFlags.Public).Select(prop => prop.Name).ToArray() 
      : openXmlEnumType.GetEnumNames();


    var membersChanged = false;
    var updatedMembers = new List<EnumMemberDeclarationSyntax>();

    foreach (var member in node.Members)
    {
      if (member is not EnumMemberDeclarationSyntax prop)
      {
        updatedMembers.Add(member);
        continue;
      }

      var hasOpenXmlEnumValueAttribute = prop.AttributeLists.SelectMany(al => al.Attributes)
        .Any(attr => attr.Name.ToString().Contains("OpenXmlEnumValue", StringComparison.Ordinal));
      if (hasOpenXmlEnumValueAttribute || !enumValues.Contains(prop.Identifier.Text))
      {
        updatedMembers.Add(prop);
        continue;
      }

      var leadingTrivia = prop.GetLeadingTrivia();
      var docTrivia = leadingTrivia.Where(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
      var otherTrivia = leadingTrivia.Except(docTrivia).ToList();


        var attributeName = "OpenXmlEnumValue";

        var attr = SyntaxFactory.Attribute(SyntaxFactory.IdentifierName(attributeName),
          SyntaxFactory.AttributeArgumentList(SyntaxFactory.SingletonSeparatedList
            (SyntaxFactory.AttributeArgument(SyntaxFactory.ParseExpression($"nameof({NamespaceMappings.Namespaces.Map[openXmlEnumType.Namespace!]}.{openXmlEnumType.Name}.{prop.Identifier.Text})")))));

        var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr))
          .WithLeadingTrivia(SyntaxFactory.TriviaList(docTrivia));
        var newProp = prop.WithLeadingTrivia(SyntaxFactory.TriviaList(otherTrivia))
          .WithAttributeLists(prop.AttributeLists.Add(attrList)).WithTrailingTrivia(prop.GetTrailingTrivia());

        membersChanged = true;
        updatedMembers.Add(newProp);
    }

    var updatedNode = node;
    if (membersChanged)
    {
      var separatedMembers = SyntaxFactory.SeparatedList(updatedMembers, node.Members.GetSeparators());
      updatedNode = updatedNode.WithMembers(separatedMembers);
      Changed = true;
    }

    if (!hasOpenXmlEnumTypeAttribute)
    {
      var attrList = CreateOpenXmlTypeAttribute(openXmlEnumType);
      updatedNode = updatedNode.AddAttributeLists(attrList);
      Changed = true;
    }

    return base.VisitEnumDeclaration(updatedNode);
  }

  /// <summary>
  /// Builds an <c>[Format(typeof(...))]</c> attribute list for a resolved Open XML enum value type.
  /// </summary>
  /// <param name="openXmlEnumType">The Open XML enum value type to reference.</param>
  /// <returns>An attribute list syntax node representing <c>[Format]</c>.</returns>
  private static AttributeListSyntax CreateOpenXmlTypeAttribute(Type openXmlEnumType)
  {
    try
    {
      var typeSyntax = SyntaxFactory.ParseTypeName(
        NamespaceMappings.Namespaces.Map[openXmlEnumType.Namespace!] + "." + openXmlEnumType.Name);
      var attribute = SyntaxFactory.Attribute(
        SyntaxFactory.IdentifierName("OpenXmlEnumType"),
        SyntaxFactory.AttributeArgumentList(
          SyntaxFactory.SingletonSeparatedList(
            SyntaxFactory.AttributeArgument(
              SyntaxFactory.TypeOfExpression(typeSyntax)))));
      return SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attribute));
    } catch (Exception ex)
    {
      Console.WriteLine($"Error occurred while creating Format attribute for {openXmlEnumType}: {ex.Message}");
      throw;
    }

  }

  /// <summary>
  /// Creates a fully-qualified type display name that preserves generic arguments for <c>typeof</c> expressions.
  /// </summary>
  /// <param name="type">Type to format.</param>
  /// <returns>A string suitable for <c>typeof</c> expressions.</returns>
  private static string GetTypeDisplayName(Type type)
  {
    if (type.IsGenericType)
    {
      var genericName = GetNonGenericTypeName(type.GetGenericTypeDefinition());
      var arguments = string.Join(
        ", ",
        type.GetGenericArguments().Select(GetTypeDisplayName));
      return $"{genericName}<{arguments}>";
    }

    return GetNonGenericTypeName(type);
  }

  /// <summary>
  /// Returns the full metadata name for a non-generic type using the <c>global::</c> prefix.
  /// </summary>
  /// <param name="type">Type to format.</param>
  /// <returns>Fully-qualified non-generic type name.</returns>
  private static string GetNonGenericTypeName(Type type)
  {
    var name = type.FullName ?? type.Name;
    name = name.Replace('+', '.');
    var tickIndex = name.IndexOf('`');
    if (tickIndex > 0)
      name = name[..tickIndex];
    return $"global::{name}";
  }

  /// <summary>
  /// Determines whether a matching static property already exists on the Open XML EnumValues type.
  /// </summary>
  /// <param name="type">The reflected EnumValues type.</param>
  /// <param name="propertyName">Property name to look up.</param>
  /// <returns><see langword="true"/> when the property exists; otherwise <see langword="false"/>.</returns>
  private bool PropertyExistsInOpenXmlType(Type type, string propertyName)
  {
    return type!.GetProperty(propertyName, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase) != null;
  }

  /// <summary>
  /// Resolves a type name via alias table, loaded assemblies, and Open XML references.
  /// </summary>
  /// <param name="typeName">Type name to resolve.</param>
  /// <param name="type">Resolved <see cref="Type"/> when successful.</param>
  /// <returns><see langword="true"/> when the type was found; otherwise <see langword="false"/>.</returns>
  private bool TryResolveOpenXmlType(string typeName, out Type? type)
  {
    //if (typeName.StartsWith("Bevel")) ;
    if (_typeCache.TryGetValue(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }
    var resolvedName = ResolveAlias(typeName);
    var types = OpenXmlAssembly?.GetTypes().Where(type => type.Name.StartsWith("Bevel"));
    type = OpenXmlAssembly?.GetTypes().FirstOrDefault(type => type.Name == resolvedName) ?? OpenXmlFrameworkAssembly?.GetTypes().FirstOrDefault(type => type.Name == resolvedName);
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

  /// <summary>
  /// Expands namespace aliases used within the processed file.
  /// </summary>
  /// <param name="typeName">Type name that may include an alias prefix.</param>
  /// <returns>The fully-qualified type name once the alias is resolved.</returns>
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