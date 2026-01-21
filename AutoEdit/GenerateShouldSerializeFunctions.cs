using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.IO;
using System.Linq;

namespace AutoEdit;

internal class GenerateShouldSerializeFunctions
{
  public static void Run(string filePath)
  {
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

    var classNode = root.DescendantNodes().OfType<ClassDeclarationSyntax>().First();
    var className = classNode.Identifier.Text;
//var baseClassNode = classNode.BaseList?.Types.FirstOrDefault();
//if (baseClassNode?.Type is GenericNameSyntax genericName)
//{
//  // It's a generic class
//  var genericTypeName = genericName.Identifier.Text; // e.g., "ModelElement"
//  var typeArguments = genericName.TypeArgumentList.Arguments; // list of type arguments

//  // You can process typeArguments as needed
//}



    var properties = classNode.Members.OfType<PropertyDeclarationSyntax>().Where(p => p.Modifiers.Any(m => m.Text == "public")).Select(p => p.Identifier.Text).ToList();

    var shouldSerializeCode = $@"namespace {namespaceName};

public partial class {className}
{{
{string.Join("\r\n", properties.Select(p => $"  public bool ShouldSerialize{p}() => {p} != null;"))}
}}
";

    var outputPath = Path.Combine(Path.GetDirectoryName(filePath)!, $"{className}.ShouldSerialize.cs");
    File.WriteAllText(outputPath, shouldSerializeCode);
    AddPartialToClass.Run(filePath);
  }
}
