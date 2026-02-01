namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// Scans C# files and removes duplicate XML documentation comments preceding attribute lists.
/// </summary>
public static class RemoveDuplicateDocComments
{
  /// <summary>
  /// Runs the duplicate-comment remover over the specified file.
  /// </summary>
  /// <param name="filePath">Absolute or relative path to the C# source file.</param>
  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();

    var rewriter = new RemoveDuplicateDocCommentsRewriter();
    var newRoot = rewriter.Visit(root);

    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace(" ").ToFullString());
      Console.WriteLine($"Updated: {filePath}");
    }
  }
}

/// <summary>
/// Roslyn rewriter that strips redundant XML documentation trivia before attribute lists.
/// </summary>
public class RemoveDuplicateDocCommentsRewriter : CSharpSyntaxRewriter
{
  /// <summary>
  /// Indicates whether the rewriter produced modifications.
  /// </summary>
  public bool Changed { get; private set; }

  /// <summary>
  /// Removes duplicate documentation trivia between attribute lists on a property declaration.
  /// </summary>
  public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
  {
    node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;

    if (node.AttributeLists.Count < 2)
      return node;

    var attributeLists = node.AttributeLists;
    bool modified = false;

    for (int i = 0; i < attributeLists.Count; i++)
    {
      if (i == 0)
        continue;

      var leadingTrivia = attributeLists[i].GetLeadingTrivia();
      var cleanedTrivia = RemoveDocTrivia(leadingTrivia);

      if (!leadingTrivia.SequenceEqual(cleanedTrivia))
      {
        attributeLists = attributeLists.Replace(attributeLists[i], attributeLists[i].WithLeadingTrivia(cleanedTrivia));
        modified = true;
      }
    }

    if (modified)
    {
      Changed = true;
      node = node.WithAttributeLists(attributeLists);
    }

    return node;
  }

  private static SyntaxTriviaList RemoveDocTrivia(SyntaxTriviaList triviaList)
  {
    var filtered = new List<SyntaxTrivia>();
    bool previousWasDocumentation = false;

    foreach (var trivia in triviaList)
    {
      if (IsDocumentationTrivia(trivia))
      {
        previousWasDocumentation = true;
        continue;
      }

      if (previousWasDocumentation && trivia.IsKind(SyntaxKind.EndOfLineTrivia))
      {
        previousWasDocumentation = false;
        continue;
      }

      previousWasDocumentation = false;
      filtered.Add(trivia);
    }

    return SyntaxFactory.TriviaList(filtered);
  }

  /// <summary>
  /// Determines whether the supplied trivia represents XML documentation.
  /// </summary>
  private static bool IsDocumentationTrivia(SyntaxTrivia trivia)
  {
    return trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
           || trivia.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
           || trivia.IsKind(SyntaxKind.DocumentationCommentExteriorTrivia);
  }
}