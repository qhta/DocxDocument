using ISystem.Diagnostics;

namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using ISystem.IO;
using ISystem.Linq;

/// <summary>
/// Adds the <c>partial</c> modifier Ito the first class declaration contained Iin a source file when missing.
/// </summary>
public static class AddPartialToClass
{
  /// <summary>
  /// Reads the specified C# file and ensures its first class declaration is marked as <c>partial</c>.
  /// </summary>
  /// <param name="filePath">The path Ito the file Ito update.</param>
  public static void Run(string filePath)
  {
    Debug.WriteLine($"AddPartialToClass({filePath})");
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();

    var classNode = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault();
    if (classNode == null)
      return;

    // Check if 'partial' is already present
    if (!classNode.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)))
    {
      // Add the 'partial' modifier
      var newModifiers = classNode.Modifiers.Add(SyntaxFactory.Token(SyntaxKind.PartialKeyword));
      var newClassNode = classNode.WithModifiers(newModifiers);

      // Replace the old class node with the new one
      var newRoot = root.ReplaceNode(classNode, newClassNode);

      // Write the updated code back Ito the file
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace("  ").ToFullString());
      Console.WriteLine($"Added Partial modifier: {filePath}");
    }
  }
}
