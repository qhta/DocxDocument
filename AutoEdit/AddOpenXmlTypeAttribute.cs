using System.Diagnostics;

namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class AddOpenXmlTypeAttribute
{
  public static void Run(string filePath)
  {
    //Console.WriteLine($"Checking: {filePath}");

    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();

    var rewriter = new AddOpenXmlTypeAttributeRewriter();
    var newRoot = rewriter.Visit(root);

    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace(" ").ToFullString());
      Console.WriteLine($"Updated: {filePath}");
    }
  }
}

public class AddOpenXmlTypeAttributeRewriter : CSharpSyntaxRewriter
{
  public bool Changed { get; private set; } = false;

  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax classNode)
  {
    if (classNode.Identifier.Text.Contains("TransformEffect")) Debug.Assert(true);

    //if (classNode.Modifiers.Any(SyntaxKind.AbstractKeyword))
    //  return classNode;

    //if (classNode.ConstraintClauses.Any())
    //  return classNode;

    var typeParameterNames = classNode.TypeParameterList?.Parameters
      .Select(p => p.Identifier.Text)
      .ToHashSet(StringComparer.Ordinal);

    if (classNode.InheritsFromGenericType(out var argTypeName) && argTypeName == null)
      return base.VisitClassDeclaration(classNode);

    var targetTypeName = argTypeName ?? classNode.GetBaseTypeName();
    if (targetTypeName == null || !targetTypeName.StartsWith("DX"))
      return base.VisitClassDeclaration(classNode);

    bool hasClassAttr = classNode.AttributeLists
      .SelectMany(al => al.Attributes)
      .Any(attr => attr.Name.ToString().Contains("OpenXmlType"));

    if (!hasClassAttr)
    {
      var openXmlTypeAttr = SyntaxFactory.Attribute(
        SyntaxFactory.IdentifierName("OpenXmlType"),
        SyntaxFactory.AttributeArgumentList(
          SyntaxFactory.SingletonSeparatedList(
            SyntaxFactory.AttributeArgument(
              SyntaxFactory.ParseExpression($"typeof({targetTypeName})")
            )
          )
        )
      );

      var leadingTrivia = classNode.GetLeadingTrivia();
      var docTrivia = leadingTrivia.Where(t =>
          t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) ||
          t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia))
        .ToList();
      var otherTrivia = leadingTrivia.Except(docTrivia).ToList();

      var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(openXmlTypeAttr))
        .WithLeadingTrivia(SyntaxFactory.TriviaList(docTrivia));
      var newClassNode = classNode
        .WithLeadingTrivia(SyntaxFactory.TriviaList(otherTrivia))
        .WithAttributeLists(classNode.AttributeLists.Add(attrList))
        .WithTrailingTrivia(classNode.GetTrailingTrivia());

      Changed = true;
      return newClassNode;
    }
    return classNode;
  }

  private static bool IsDocumentationTrivia(SyntaxTrivia trivia)
  {
    return trivia.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia)
           || trivia.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)
           || trivia.IsKind(SyntaxKind.DocumentationCommentExteriorTrivia);
  }

  private static bool HasConcreteTypeArgument(GenericNameSyntax genericName, HashSet<string>? typeParameterNames)
  {
    var firstArgument = genericName.TypeArgumentList.Arguments.FirstOrDefault();
    return IsConcreteTypeArgument(firstArgument, typeParameterNames);
  }

  private static bool IsConcreteTypeArgument(TypeSyntax? typeSyntax, HashSet<string>? typeParameterNames)
  {
    if (typeSyntax == null)
      return false;

    if (typeSyntax is IdentifierNameSyntax identifierName)
    {
      return typeParameterNames == null || !typeParameterNames.Contains(identifierName.Identifier.Text);
    }

    if (typeSyntax is NullableTypeSyntax nullableType)
      return IsConcreteTypeArgument(nullableType.ElementType, typeParameterNames);

    return true;
  }

  private static (SyntaxTriviaList docTrivia, SyntaxTriviaList remainingTrivia) SplitDocumentationTrivia(SyntaxTriviaList leadingTrivia)
  {
    int lastDocIndex = -1;
    for (int i = 0; i < leadingTrivia.Count; i++)
    {
      if (IsDocumentationTrivia(leadingTrivia[i]))
      {
        lastDocIndex = i;
      }
    }

    if (lastDocIndex == -1)
      return (SyntaxFactory.TriviaList(), leadingTrivia);

    int includeUpTo = lastDocIndex;
    if (includeUpTo + 1 < leadingTrivia.Count && leadingTrivia[includeUpTo + 1].IsKind(SyntaxKind.EndOfLineTrivia))
    {
      includeUpTo++;
    }

    var docTrivia = SyntaxFactory.TriviaList(leadingTrivia.Take(includeUpTo + 1));
    var remainingTrivia = SyntaxFactory.TriviaList(leadingTrivia.Skip(includeUpTo + 1));
    return (docTrivia, remainingTrivia);
  }
}