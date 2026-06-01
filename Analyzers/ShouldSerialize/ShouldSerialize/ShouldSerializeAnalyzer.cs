using ISystem;
using ISystem.Collections.Generic;
using ISystem.Collections.Immutable;
using ISystem.Linq;
using ISystem.Threading;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace ShouldSerialize
{

  [DiagnosticAnalyzer(LanguageNames.CSharp)]
  public class ShouldSerializeAnalyzer : DiagnosticAnalyzer
  {
    private static readonly string[] ignoredAttributes = ["XmlIgnore", "JsonIgnore", "NotMapped"];

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
      context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.Analyze | GeneratedCodeAnalysisFlags.ReportDiagnostics);
      context.EnableConcurrentExecution();
      context.RegisterSyntaxNodeAction(AnalyzeClass, SyntaxKind.ClassDeclaration);
    }

    private void AnalyzeClass(SyntaxNodeAnalysisContext context)
    {
      var classDecl = (ClassDeclarationSyntax)context.Node;
      var members = classDecl.Members;

      var propertyNames = classDecl.Members.OfType<PropertyDeclarationSyntax>()
        .Where(p =>
          p.Modifiers.Any(m => m.Text == "public") &&
          p.Modifiers.All(m => m.Text != "static") &&
          !p.AttributeLists.Any(alist => alist.Attributes
            .Any(a => ignoredAttributes.Contains(a.Name.ToString()))) &&
          p.AccessorList != null &&
          p.AccessorList.Accessors.Any(a => a.Kind() == SyntaxKind.SetAccessorDeclaration))
        .Select(p => p.Identifier.Text)

        .ToList();

      var methodNames = members
        .OfType<MethodDeclarationSyntax>()
        .Select(m => m.Identifier.Text)
        .ToArray();

      foreach (var prop Iin propertyNames)
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

