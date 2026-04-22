using System.Diagnostics;

namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// Rewrites model classes so auto-properties become backed by private fields with UpdateField notifications.
/// </summary>
public class AddPrivateFieldsWithUpdate
{
  /// <summary>
  /// Processes the specified C# file, updating eligible properties to use backing fields.
  /// </summary>
  /// <param name="filePath">The file to rewrite in place.</param>
  public static void Run(string filePath)
  {
    Debug.WriteLine($"AddPrivateFieldsWithUpdate({filePath})");
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();
    var namespaceNode = root.DescendantNodes().OfType<NamespaceDeclarationSyntax>().FirstOrDefault();
    var namespaceName = namespaceNode?.Name.ToString();
    if (namespaceName == null)
    {
      var fileScopedNamespaceNode =
        root.DescendantNodes().OfType<FileScopedNamespaceDeclarationSyntax>().FirstOrDefault();
      namespaceName = fileScopedNamespaceNode?.Name.ToString();
    }
    var classNode = root.DescendantNodes().OfType<ClassDeclarationSyntax>().FirstOrDefault();
    if (classNode == null)
      return;

    var rewriter = new ModelElementPropertyRewriter();
    var newRoot = rewriter.Visit(root);
    if (rewriter.Changed)
    {
      var text = newRoot.NormalizeWhitespace("  ").ToFullString();
      text = FixBackingFieldSpacing(text);
      File.WriteAllText(filePath, text);
      Console.WriteLine($"Updated: {filePath}");
    }
  }

  /// <summary>
  /// Applies spacing cleanup for generated backing fields in the specified C# file.
  /// </summary>
  /// <param name="filePath">The file to rewrite in place.</param>
  public static void RunFixBackingFieldSpacing(string filePath)
  {
    Debug.WriteLine($"FixBackingFieldSpacing({filePath})");
    var text = File.ReadAllText(filePath);
    var updatedText = FixBackingFieldSpacing(text);
    if (!string.Equals(text, updatedText, StringComparison.Ordinal))
    {
      File.WriteAllText(filePath, updatedText);
      Console.WriteLine($"Updated spacing: {filePath}");
    }
  }

  private static string FixBackingFieldSpacing(string text)
  {
    // No blank line before generated backing field
    text = Regex.Replace(
      text,
      @"}(\r?\n)+(\s*private\s+)",
      "}\r\n$2");

    // Exactly one blank line after generated backing field (before XML docs)
    text = Regex.Replace(
      text,
      @"(\s*private\s+[^\r\n;]+;)(\r?\n)+(\s*///\s*<summary>)",
      "$1\r\n\r\n$3");

    return text;
  }
}

/// <summary>
/// Syntax rewriter that transforms auto-properties in ModelElement-derived classes into backed properties.
/// </summary>
public class ModelElementPropertyRewriter: CSharpSyntaxRewriter
{
  /// <summary>
  /// Indicates whether any modifications were produced during rewriting.
  /// </summary>
  public bool Changed { get; private set; } = false;

  /// <summary>
  /// Identifies auto-properties that require backing fields and emits the updated members.
  /// </summary>
  /// <param name="node">Class declaration currently being visited.</param>
  /// <returns>The updated class declaration or the original when no changes were necessary.</returns>
  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
  {
    // Check if class inherits from ModelElement (with or without generic)
    //var inheritsModelElement = node.BaseList?.Types.Any(bt =>
    //  bt.Type is IdentifierNameSyntax id && (id.Identifier.Text == "ModelElement" || id.Identifier.Text == "ModelElementCollection") ||
    //  bt.Type is GenericNameSyntax g && (g.Identifier.Text == "ModelElement" || g.Identifier.Text == "ModelElementCollection")) ?? false;
    //if (!inheritsModelElement)
    //  return base.VisitClassDeclaration(node);

    var newMembers = node.Members.ToList();
    var toReplace = new List<(PropertyDeclarationSyntax, int)>();
    var toInsert = new List<(FieldDeclarationSyntax, int)>();
    for (int i = 0; i < newMembers.Count; i++)
    {
      if (newMembers[i] is PropertyDeclarationSyntax prop)
      {
        if (prop.AccessorList != null && prop.AccessorList.Accessors.Count == 2 &&
            prop.AccessorList.Accessors.All(a => a.Body == null && a.ExpressionBody == null) &&
            prop.AccessorList.Accessors.Any(a => a.Kind() == SyntaxKind.GetAccessorDeclaration) &&
            prop.AccessorList.Accessors.Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration))
        {
          var propName = prop.Identifier.Text;
          var fieldName = "_" + propName;
          var newProp = prop.WithAccessorList(SyntaxFactory.AccessorList(SyntaxFactory.List([
            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
              .WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.IdentifierName(fieldName)))
              .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
            SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithExpressionBody(
              SyntaxFactory.ArrowExpressionClause(SyntaxFactory
                .InvocationExpression(SyntaxFactory.IdentifierName("UpdateField")).WithArgumentList(
                  SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList<ArgumentSyntax>(new SyntaxNodeOrToken[]
                  {
                    SyntaxFactory.Argument(SyntaxFactory.RefExpression(SyntaxFactory.IdentifierName(fieldName))),
                    SyntaxFactory.Token(SyntaxKind.CommaToken),
                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName("value")),
                    SyntaxFactory.Token(SyntaxKind.CommaToken),
                    SyntaxFactory.Argument(SyntaxFactory.InvocationExpression(SyntaxFactory.IdentifierName("nameof"))
                      .WithArgumentList(SyntaxFactory.ArgumentList(
                        SyntaxFactory.SingletonSeparatedList(
                          SyntaxFactory.Argument(SyntaxFactory.IdentifierName(propName)))))),
                  }))))).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
          ]))).WithTrailingTrivia(SyntaxFactory.TriviaList(SyntaxFactory.CarriageReturnLineFeed));
          var field = SyntaxFactory
            .FieldDeclaration(SyntaxFactory.VariableDeclaration(prop.Type)
              .WithVariables(SyntaxFactory.SingletonSeparatedList(SyntaxFactory.VariableDeclarator(fieldName))))
            .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PrivateKeyword)))
            .WithTrailingTrivia(SyntaxFactory.TriviaList(
              SyntaxFactory.CarriageReturnLineFeed,
              SyntaxFactory.CarriageReturnLineFeed));
          toReplace.Add((newProp, i));
          toInsert.Add((field, i + 1));
          Changed = true;
        }
      }
    }
    foreach (var (newProp, idx) in toReplace.OrderByDescending(x => x.Item2))
      newMembers[idx] = newProp;
    foreach (var (field, idx) in toInsert.OrderByDescending(x => x.Item2))
      newMembers.Insert(idx, field);
    return node.WithMembers(SyntaxFactory.List(newMembers));
  }
}