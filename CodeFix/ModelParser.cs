using System.Diagnostics;
using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CodeFix;
public class ModelParser
{
  public ModelParser(string rootCodePath, IEnumerable<Type> types)
  {
    SourcePath = rootCodePath;
    OutputPath = Path.Combine(Path.GetDirectoryName(rootCodePath) ?? "", "New" + Path.GetFileName(rootCodePath));
    foreach (var type in types)
    {
      Debug.Assert(type.FullName != null);
      KnownTypes.Add(type.FullName, type);
    }
  }

  public string SourcePath { get; private set; }
  public string OutputPath { get; private set; }

  public Dictionary<string, Type> KnownTypes { get; private set; } = new Dictionary<string, Type>();
  public TextWriter Output = null!;

  public void ParseType(string filename)
  {
    var srcFilename = Path.Combine(SourcePath, filename);
    string code;
    using (TextReader reader = File.OpenText(srcFilename))
    {
      code = reader.ReadToEnd();
    }
    var newFilename = Path.Combine(OutputPath, filename);
    var dirName = Path.GetDirectoryName(newFilename);
    Debug.Assert(dirName!=null);
    if (!Directory.Exists(dirName))
      Directory.CreateDirectory(dirName);
    using (Output = File.CreateText(newFilename))
    {
      Debug.WriteLine($"Parsing {filename}");
      SyntaxTree syntaxTree = CSharpSyntaxTree.ParseText(code
        , new CSharpParseOptions
        (documentationMode: DocumentationMode.Parse,
          preprocessorSymbols: new string[] { "PRAGMA", "CONDITIONAL" })
        );
      CompilationUnitSyntax root = (CompilationUnitSyntax)syntaxTree.GetRoot();
      WriteSyntaxMode(root);
    }
  }

  int MaxDepth = int.MaxValue;
  private void ShowSyntaxNode(SyntaxNodeOrToken currNodeOrToken, int depth = 0)
  {
    Debug.Indent();
    Debug.WriteLine(currNodeOrToken.Kind());
    var currToken = currNodeOrToken.AsToken();
    if (currToken.HasLeadingTrivia)
    {
      Debug.Indent();
      Debug.WriteLine("LeadingTrivia:");
      {
        Debug.Indent();
        foreach (var trivia in currToken.LeadingTrivia)
          Debug.WriteLine(trivia.Kind());
        Debug.Unindent();
      }
      Debug.Unindent();
    }
    if (currToken.HasTrailingTrivia)
    {
      Debug.Indent();
      Debug.WriteLine("TrailingTrivia:");
      {
        Debug.Indent();
        foreach (var trivia in currToken.TrailingTrivia)
          Debug.WriteLine(trivia.Kind());
        Debug.Unindent();
      }
      Debug.Unindent();
    }
    var currNode = currNodeOrToken.AsNode();
    if (currNode != null)
    {
      depth++;
      if (depth < MaxDepth)
        foreach (var subNodeOrToken in currNode.ChildNodesAndTokens().ToList())
          ShowSyntaxNode(subNodeOrToken, depth);
    }
    Debug.Unindent();
  }

  private void WriteSyntaxMode(SyntaxNodeOrToken currNodeOrToken)
  {
    var currToken = currNodeOrToken.AsToken();
    if (currToken.HasLeadingTrivia)
    {
      foreach (var trivia in currToken.LeadingTrivia)
        Output.Write(trivia);
    }
    Output.Write(currNodeOrToken);
    if (currToken.HasTrailingTrivia)
    {
      foreach (var trivia in currToken.TrailingTrivia)
        Output.Write(trivia);
    }
  }

}
