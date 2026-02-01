using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoEdit;

/// <summary>
/// Moves files containing enum declarations into an <c>Enums</c> subdirectory to keep models organized.
/// </summary>
public static class MoveEnumType
{

  /// <summary>
  /// Relocates the specified file when it contains one or more enum declarations.
  /// </summary>
  /// <param name="filePath">Absolute or relative path to the source file to inspect.</param>
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
    File.Move(filePath, newPath, overwrite: true);
    Console.WriteLine($"Moved {filePath} to {newPath}");
  }
}
