using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

using System.Linq;

namespace AutoEdit;

internal class GenerateShouldSerializeFunctions
{
  private static readonly string[] ignoredAttributes = [ "XmlIgnore", "JsonIgnore", "NotMapped"];
  public static void Run(string filePath)
  {
    var filename = Path.GetFileNameWithoutExtension(filePath);
    var ShouldSerializeFile = filename + ".ShouldSerialize.cs";
    if (File.Exists(Path.Combine(Path.GetDirectoryName(filePath)!, ShouldSerializeFile)))
      return;
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();


    var namespaceNode = root.DescendantNodes().OfType<NamespaceDeclarationSyntax>().FirstOrDefault();
    var namespaceName = namespaceNode?.Name.ToString();
    if (namespaceName == null)
    {
      var fileScopedNamespaceNode = root.DescendantNodes().OfType<FileScopedNamespaceDeclarationSyntax>().FirstOrDefault();
      namespaceName = fileScopedNamespaceNode?.Name.ToString();
    }

    var classNode = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault();
    if (classNode == null)
      return;
    var className = classNode.Identifier.Text;
    

    var properties = classNode.Members.OfType<PropertyDeclarationSyntax>()
      .Where(p =>
        p.Modifiers.Any(m => m.Text == "public") &&
        p.Modifiers.All(m => m.Text != "static") &&
        !p.AttributeLists.Any(alist => alist.Attributes
          .Any(a => ignoredAttributes.Contains(a.Name.ToString()))) &&
        p.AccessorList != null &&
        p.AccessorList.Accessors.Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration))

      .ToList();
    Dictionary<string, string> propertyTypes = new();
    foreach (var prop in properties)
    {
      var propName = prop.Identifier.Text;
      var propType = prop.Type;
      if (propType is NullableTypeSyntax)
      {
        propertyTypes[propName] = $"{propName} is not null";
      }
      else if (propType is PredefinedTypeSyntax predefinedType)
      {
        var typeKeyword = predefinedType.Keyword.Text;
        switch (typeKeyword)
        {
          //case "int":
          //case "long":
          //case "float":
          //case "double":
          //case "decimal":
          //  propertyTypes[propName] = $"{propName} != 0";
          //  break;
          case "bool":
            propertyTypes[propName] = $"{propName} == true";
            break;
          //case "char":
          //  propertyTypes[propName] = $"{propName} != '\\0'";
          //  break;
          default:
            break;
        }
      }
    }

    if (propertyTypes.Count == 0)
      return;

    var typeParams = classNode.TypeParameterList?.ToFullString() ?? "";
    var classDecl = $"{className}{typeParams}";

    var shouldSerializeCode = $@"namespace {namespaceName};

public partial class {classDecl}
{{
{string.Join("\r\n", propertyTypes.Select(p => $"  public bool ShouldSerialize{p.Key}() => {p.Value};"))}
}}
";

    var outputPath = Path.Combine(Path.GetDirectoryName(filePath)!, $"{className}.ShouldSerialize.cs");
    File.WriteAllText(outputPath, shouldSerializeCode);
    Console.WriteLine($"Generated ShouldSerialize functions: {outputPath}");
    AddPartialToClass.Run(filePath);
  }
}
