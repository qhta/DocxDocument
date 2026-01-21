using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace ShouldSerialize
{
  [DiagnosticAnalyzer(LanguageNames.CSharp)]
  public class ShouldSerializeAnalyzer : DiagnosticAnalyzer
  {
    public const string DiagnosticId = "ShouldSerialize";
    private static readonly DiagnosticDescriptor Rule = new DiagnosticDescriptor(
      DiagnosticId,
      "Missing ShouldSerialize method",
      "Property '{0}' should have a ShouldSerialize{0}() method",
      "Usage",
      DiagnosticSeverity.Info,
      isEnabledByDefault: true);

    public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(Rule);

    public override void Initialize(AnalysisContext context)
    {
      context.EnableConcurrentExecution();
      context.RegisterSyntaxNodeAction(AnalyzeClass, SyntaxKind.ClassDeclaration);
    }

    private void AnalyzeClass(SyntaxNodeAnalysisContext context)
    {
      var classDecl = (ClassDeclarationSyntax)context.Node;
      var members = classDecl.Members;

      var propertyNames = members
        .OfType<PropertyDeclarationSyntax>()
        .Where(p => p.Modifiers.Any(m => m.IsKind(SyntaxKind.PublicKeyword)))
        .Select(p => p.Identifier.Text)
        .ToList();

      var methodNames = members
        .OfType<MethodDeclarationSyntax>()
        .Select(m => m.Identifier.Text)
        .ToArray();

      foreach (var prop in propertyNames)
      {
        var shouldSerializeName = $"ShouldSerialize{prop}";
        if (!methodNames.Contains(shouldSerializeName))
        {
          var propNode = members.OfType<PropertyDeclarationSyntax>().First(p => p.Identifier.Text == prop);
          var diagnostic = Diagnostic.Create(Rule, propNode.Identifier.GetLocation(), prop);
          context.ReportDiagnostic(diagnostic);
        }
      }
    }
  }
}
