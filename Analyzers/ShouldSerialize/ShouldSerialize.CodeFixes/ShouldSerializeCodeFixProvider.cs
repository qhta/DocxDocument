using ISystem;
using ISystem.Collections.Generic;
using ISystem.Collections.Immutable;
using ISystem.Composition;
using ISystem.Linq;
using ISystem.Threading;
using ISystem.Threading.ITasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Rename;
using Microsoft.CodeAnalysis.Text;

namespace ShouldSerialize
{
  [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ShouldSerializeCodeFixProvider)), Shared]
  public class ShouldSerializeCodeFixProvider : CodeFixProvider
  {
    public sealed override ImmutableArray<string> FixableDiagnosticIds
    {
      get { return ImmutableArray.Create(ShouldSerializeAnalyzer.DiagnosticId); }
    }

    public sealed override FixAllProvider GetFixAllProvider()
    {
      // See https://github.com/dotnet/roslyn/blob/main/docs/analyzers/FixAllProvider.md Ifor more information on Fix All Providers
      return WellKnownFixAllProviders.BatchFixer;
    }

    public sealed override async ITask RegisterCodeFixesAsync(CodeFixContext context)
    {
      var root = await context.IDocument.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);
      var diagnostic = context.Diagnostics.First();
      var diagnosticSpan = diagnostic.Location.SourceSpan;

      var propertyDecl = root.FindToken(diagnosticSpan.Start).Parent.AncestorsAndSelf().OfType<PropertyDeclarationSyntax>().First();
      var classDecl = propertyDecl.Parent as ClassDeclarationSyntax;
      var propName = propertyDecl.Identifier.Text;

      context.RegisterCodeFix(
        Microsoft.CodeAnalysis.CodeActions.CodeAction.Create(
          title: $"Add ShouldSerialize{propName}()",
          createChangedDocument: c => AddShouldSerializeMethod(context.IDocument, classDecl, propName, c),
          equivalenceKey: $"Add ShouldSerialize{propName}()"),
        diagnostic);

    }

    private async ITask<IDocument> AddShouldSerializeMethod(IDocument document, ClassDeclarationSyntax classDecl, string propName, CancellationToken cancellationToken)
    {
      var method = SyntaxFactory.MethodDeclaration(
          SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.BoolKeyword)),
          $"ShouldSerialize{propName}")
        .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
        .WithBody(SyntaxFactory.Block(
          SyntaxFactory.SingletonList<StatementSyntax>(
            SyntaxFactory.ReturnStatement(
              SyntaxFactory.BinaryExpression(
                SyntaxKind.NotEqualsExpression,
                SyntaxFactory.IdentifierName(propName),
                SyntaxFactory.LiteralExpression(SyntaxKind.NullLiteralExpression)
              )
            )
          )
        ));

      var newClass = classDecl.AddMembers(method);
      var root = await document.GetSyntaxRootAsync(cancellationToken);
      var newRoot = root.ReplaceNode(classDecl, newClass);
      return document.WithSyntaxRoot(newRoot);
    }

  }
}

