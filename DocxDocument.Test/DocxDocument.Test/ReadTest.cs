using System.Diagnostics;
using System.Text;

using DocumentFormat.OpenXml.Packaging;

using DocumentModel.Utils;

using Microsoft.VisualStudio.TestPlatform.Utilities;
using DM = DocumentModel;

namespace DocxDocument.Test;

[TestClass]
public class ReadTest
{
  public TextWriter Output { get; set; } = null!;
  public string SamplesPath = null!;

  [TestInitialize()]
  public void Initialize()
  {
    //Console.SetOut(ConsoleOutput);    // Associate StringBuilder with StdOut
    //this.ConsoleOutput.Clear();    // Clear text from any previous text runs
    SamplesPath = GetSamplesPath();
  }

  [TestMethod]
  public void TestOpen()
  {
    var samplesPath = SamplesPath;
    foreach (var file in Directory.GetFiles(samplesPath, "*.docx"))
    {
      Output.WriteLine($"TestOpen: {file}");
      try
      {
        using (var document = DM.Document.Open(file, false))
          Output.WriteLine($"  Type: {document.DocumentType}");
      }
      catch (Exception ex)
      {
        Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
      }
    }
  }

  [TestMethod]
  public void TestReadProperties()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentProperties.docx");
    Output.WriteLine($"TestReadProperties: {file}");
    try
    {
      using (var document = DM.Document.Open(file, false))
      {
        Output.WriteLine($"  Title: {document.BuiltInProperties.Title}");
        Output.WriteLine($"  CreatedBy: {document.BuiltInProperties.CreatedBy}");
        Output.WriteLine($"  CreatedAt: {document.BuiltInProperties.CreatedAt}");
        Output.WriteLine($"  LastModifiedBy: {document.BuiltInProperties.LastModifiedBy}");
        Output.WriteLine($"  LastModifiedAt: {document.BuiltInProperties.LastModifiedAt}");
        Output.WriteLine($"  LastPrintedAt: {document.BuiltInProperties.LastPrintedAt}");
        Output.WriteLine($"  Subject: {document.BuiltInProperties.Subject}");
        Output.WriteLine($"  Revision: {document.BuiltInProperties.Revision}");
        Output.WriteLine($"  Language: {document.BuiltInProperties.Language}");
        Output.WriteLine($"  Keywords: {document.BuiltInProperties.Keywords}");
        Output.WriteLine($"  CoreIdentifier: {document.BuiltInProperties.CoreIdentifier}");
        Output.WriteLine($"  ContentType: {document.BuiltInProperties.ContentType}");
        Output.WriteLine($"  ContentStatus: {document.BuiltInProperties.ContentStatus}");
        Output.WriteLine($"  Category: {document.BuiltInProperties.Category}");
        Output.WriteLine($"  Description: {document.BuiltInProperties.Description}");
        Output.WriteLine($"  Version: {document.BuiltInProperties.Version}");

        Output.WriteLine($"  DigitalSignature: {document.BuiltInProperties.DigitalSignature}");
        Output.WriteLine($"  TitlesOfParts: {document.BuiltInProperties.TitlesOfParts?.AsString()}");
        Output.WriteLine($"  HeadingPairs: {document.BuiltInProperties.HeadingPairs?.AsString()}");
        Output.WriteLine($"  HyperlinkList: {document.BuiltInProperties.HyperlinkList}");
        Output.WriteLine($"  DocumentSecurity: {document.BuiltInProperties.DocumentSecurity}");
        Output.WriteLine($"  ScaleCrop: {document.BuiltInProperties.ScaleCrop}");
        Output.WriteLine($"  LinksUpToDate: {document.BuiltInProperties.LinksUpToDate}");
        Output.WriteLine($"  SharedDocument: {document.BuiltInProperties.SharedDocument}");
        Output.WriteLine($"  HyperlinksChanged: {document.BuiltInProperties.HyperlinksChanged}");
        Output.WriteLine($"  HyperlinkBase: {document.BuiltInProperties.HyperlinkBase}");
        Output.WriteLine($"  Template: {document.BuiltInProperties.Template}");
        Output.WriteLine($"  Manager: {document.BuiltInProperties.Manager}");
        Output.WriteLine($"  Company: {document.BuiltInProperties.Company}");
        Output.WriteLine($"  PresentationFormat: {document.BuiltInProperties.PresentationFormat}");
        Output.WriteLine($"  Application: {document.BuiltInProperties.Application}");
        Output.WriteLine($"  ApplicationVersion: {document.BuiltInProperties.ApplicationVersion}");

        Output.WriteLine($"  Pages: {document.BuiltInProperties.Pages}");
        Output.WriteLine($"  Words: {document.BuiltInProperties.Words}");
        Output.WriteLine($"  Characters: {document.BuiltInProperties.Characters}");
        Output.WriteLine($"  CharactersWithSpaces: {document.BuiltInProperties.CharactersWithSpaces}");
        Output.WriteLine($"  Lines: {document.BuiltInProperties.Lines}");
        Output.WriteLine($"  Paragraphs: {document.BuiltInProperties.Paragraphs}");
        Output.WriteLine($"  TotalTime: {document.BuiltInProperties.TotalTime}");

        if (document.HasCustomProperties)
          foreach (var item in document.CustomProperties)
            Output.WriteLine($"  {item.Name}: {item.Value}");
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
  }

  private string GetSamplesPath()
  {
    string result = Environment.CurrentDirectory!;
    while (!result.EndsWith(".Test"))
      result = Path.GetDirectoryName(result)!;
    var subResult = Path.GetDirectoryName(result)!;
    while (subResult.EndsWith(".Test"))
      return subResult;
    return result;
  }

}