using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoEdit;

public static class MoveEnumType
{

  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetCompilationUnitRoot();

    List<BaseNamespaceDeclarationSyntax> namespaceDeclarations = root.Members.OfType<FileScopedNamespaceDeclarationSyntax>().ToList<BaseNamespaceDeclarationSyntax>();
    namespaceDeclarations.AddRange(root.Members.OfType<NamespaceDeclarationSyntax>());
    if (!namespaceDeclarations.Any(ns => ns.Members.OfType<EnumDeclarationSyntax>().Any()))
      return;

    foreach (var namespaceDeclaration in namespaceDeclarations)
    {
      var enums = namespaceDeclaration.Members.OfType<EnumDeclarationSyntax>().ToList();
      if (!enums.Any())
        return;
    }

    var directory = Path.GetDirectoryName(filePath)!;
    var enumsDir = Path.Combine(directory, "Enums");
    Directory.CreateDirectory(enumsDir);

    var newPath = Path.Combine(enumsDir, Path.GetFileName(filePath));
    if (File.Exists(newPath)) File.Delete(newPath);
    File.Move(filePath, newPath);
    Console.WriteLine($"Moved {filePath} to {newPath}");
  }
}
