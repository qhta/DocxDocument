namespace AutoEdit;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.IO;
using System.Linq;

public static class AddOpenXmlPropertyAttribute
{
  public static void Run(string filePath)
  {
    var code = File.ReadAllText(filePath);
    var tree = CSharpSyntaxTree.ParseText(code);
    var root = tree.GetRoot();

    var rewriter = new AddOpenXmlPropertyAttributeRewriter();
    var newRoot = rewriter.Visit(root);

    if (rewriter.Changed)
    {
      File.WriteAllText(filePath, newRoot.NormalizeWhitespace().ToFullString());
      Console.WriteLine($"Updated: {filePath}");
    }
  }
  
}

public class AddOpenXmlPropertyAttributeRewriter : CSharpSyntaxRewriter
{
  public bool Changed { get; private set; } = false;

  public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
  {
    // Check if class inherits from ModelElement<T>
    var baseType = node.BaseList?.Types
        .Select(bt => bt.Type)
        .OfType<GenericNameSyntax>()
        .FirstOrDefault(g => g.Identifier.Text == "ModelElement");

    if (baseType == null)
      return base.VisitClassDeclaration(node);

    // Get the type parameter (OpenXml type)
    var openXmlType = baseType.TypeArgumentList.Arguments.First().ToString();

    // --- Add [OpenXmlType(typeof(OpenXmlType))] attribute to the class ---
    bool hasClassAttr = node.AttributeLists
      .SelectMany(al => al.Attributes)
      .Any(attr => attr.Name.ToString().Contains("OpenXmlType"));

    ClassDeclarationSyntax newClassNode = node;
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

      // Insert attribute after XML doc comments, before class keyword
      var leadingTrivia = node.GetLeadingTrivia();
      var docCommentTrivia = leadingTrivia.Where(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
      var otherTrivia = leadingTrivia.Except(docCommentTrivia).ToList();

      // Attach doc comments to the class, and attribute after them
      newClassNode = node
        .WithAttributeLists(node.AttributeLists.Insert(0, attrList))
        .WithLeadingTrivia(leadingTrivia);
      Changed = true;
    }

    // --- Add [OpenXmlProperty(nameof(OpenXmlType.PropertyName))] to each property ---
    var newMembers = newClassNode.Members.Select(member =>
    {
      if (member is PropertyDeclarationSyntax prop)
      {
        // Check if already has OpenXmlProperty attribute
        bool hasAttr = prop.AttributeLists
            .SelectMany(al => al.Attributes)
            .Any(attr => attr.Name.ToString().Contains("OpenXmlProperty"));

        if (!hasAttr)
        {
          // Split leading trivia into doc comments and other trivia
          var leadingTrivia = prop.GetLeadingTrivia();
          var docTrivia = leadingTrivia.Where(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia) || t.IsKind(SyntaxKind.MultiLineDocumentationCommentTrivia)).ToList();
          var otherTrivia = leadingTrivia.Except(docTrivia).ToList();

          var attr = SyntaxFactory.Attribute(
            SyntaxFactory.IdentifierName("OpenXmlProperty"),
            SyntaxFactory.AttributeArgumentList(
              SyntaxFactory.SingletonSeparatedList(
                SyntaxFactory.AttributeArgument(
                  SyntaxFactory.ParseExpression($"nameof({openXmlType}.{prop.Identifier.Text})")
                )
              )
            )
          );
          var attrList = SyntaxFactory.AttributeList(SyntaxFactory.SingletonSeparatedList(attr));

          // Remove doc comments from leading trivia, add attribute, then re-add doc comments as leading trivia
         
          var newProp = prop
            .WithLeadingTrivia(docTrivia)
            .WithAttributeLists(prop.AttributeLists.Add(attrList))
            .WithTrailingTrivia(prop.GetTrailingTrivia());

          Changed = true;
          return (MemberDeclarationSyntax)newProp;
        }
      }
      return member;
    }).ToList();

    return newClassNode.WithMembers(SyntaxFactory.List(newMembers));
  }
}