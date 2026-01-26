namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.IO;
using System.Linq;

public static class AddOpenXmlTypeAttribute
{
  public static void Run(string filePath)
  {
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

  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
  {
    if (node.Modifiers.Any(SyntaxKind.AbstractKeyword))
      return node;

    if (node.ConstraintClauses.Any())
      return node;

    var baseType = node.BaseList?.Types
        .Select(bt => bt.Type)
        .OfType<GenericNameSyntax>()
        .FirstOrDefault(g => g.Identifier.Text == "ModelElement");

    if (baseType == null)
      return base.VisitClassDeclaration(node);
    var openXmlType = baseType.TypeArgumentList.Arguments.First().ToString();

    bool hasClassAttr = node.AttributeLists
      .SelectMany(al => al.Attributes)
      .Any(attr => attr.Name.ToString().Contains("OpenXmlType"));

    if (!hasClassAttr)
    {
      var openXmlTypeAttr = SyntaxFactory.Attribute(
        SyntaxFactory.IdentifierName("OpenXmlType"),
        SyntaxFactory.AttributeArgumentList(
          SyntaxFactory.SingletonSeparatedList(
            SyntaxFactory.AttributeArgument(
              SyntaxFactory.ParseExpression($"typeof({openXmlType})")
            )
          )
        )
      );
      var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(openXmlTypeAttr));

      var leadingTrivia = node.GetLeadingTrivia();
      var newClassNode = node
        .WithAttributeLists(node.AttributeLists.Insert(0, attrList))
        .WithLeadingTrivia(leadingTrivia);

      Changed = true;
      return newClassNode;
    }
    return node;
  }
}