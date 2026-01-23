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
    File.Move(filePath, newPath, overwrite: true);
    Console.WriteLine($"Moved {filePath} to {newPath}");

    //    // split: remove enums from original filePath
    //    var newRoot = root.RemoveNodes(enums, SyntaxRemoveOptions.KeepNoTrivia);
    //#pragma warning disable CS8631 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match constraint type.
    //    File.WriteAllText(filePath, newRoot.NormalizeWhitespace("  ")!.ToFullString());
    //#pragma warning restore CS8631 // The type cannot be used as type parameter in the generic type or method. Nullability of type argument doesn't match constraint type.

    //    foreach (var @enum in enums)
    //    {
    //      var enumSyntax = SyntaxFactory.CompilationUnit()
    //        .WithUsings(root.Usings)
    //        .WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(
    //          SyntaxFactory.NamespaceDeclaration(((NamespaceDeclarationSyntax)root.Members.First(m => m is NamespaceDeclarationSyntax))).WithMembers(SyntaxFactory.SingletonList<MemberDeclarationSyntax>(@enum))))
    //        .NormalizeWhitespace();

    //      var enumPath = Path.Combine(enumsDir, $"{@enum.Identifier.Text}.cs");
    //      File.WriteAllText(enumPath, enumSyntax.ToFullString());
    //    }
  }
}
