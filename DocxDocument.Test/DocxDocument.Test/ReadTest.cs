using System.Diagnostics;
using System.Text;

using DocumentFormat.OpenXml.Packaging;

using DocumentModel.Utils;

using Microsoft.VisualStudio.TestPlatform.Utilities;
using DMW = DocumentModel.Wordprocessing;

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
        using (var document = DMW.DocxDocument.Open(file, false))
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
      using (var document = DMW.DocxDocument.Open(file, false))
      {
        Output.WriteLine($"  Title: {document.Title}");
        Output.WriteLine($"  CreatedBy: {document.CreatedBy}");
        Output.WriteLine($"  CreatedAt: {document.CreatedAt}");
        Output.WriteLine($"  LastModifiedBy: {document.LastModifiedBy}");
        Output.WriteLine($"  LastModifiedAt: {document.LastModifiedAt}");
        Output.WriteLine($"  LastPrintedAt: {document.LastPrintedAt}");
        Output.WriteLine($"  Subject: {document.Subject}");
        Output.WriteLine($"  Revision: {document.Revision}");
        Output.WriteLine($"  Language: {document.Language}");
        Output.WriteLine($"  Keywords: {document.Keywords}");
        Output.WriteLine($"  CoreIdentifier: {document.CoreIdentifier}");
        Output.WriteLine($"  ContentType: {document.ContentType}");
        Output.WriteLine($"  ContentStatus: {document.ContentStatus}");
        Output.WriteLine($"  Category: {document.Category}");
        Output.WriteLine($"  Description: {document.Description}");
        Output.WriteLine($"  Version: {document.Version}");

        Output.WriteLine($"  DigitalSignature: {document.DigitalSignature}");
        Output.WriteLine($"  TitlesOfParts: {document.TitlesOfParts?.AsString()}");
        Output.WriteLine($"  HeadingPairs: {document.HeadingPairs?.AsString()}");
        Output.WriteLine($"  HyperlinkList: {document.HyperlinkList}");
        Output.WriteLine($"  DocumentSecurity: {document.DocumentSecurity}");
        Output.WriteLine($"  ScaleCrop: {document.ScaleCrop}");
        Output.WriteLine($"  LinksUpToDate: {document.LinksUpToDate}");
        Output.WriteLine($"  SharedDocument: {document.SharedDocument}");
        Output.WriteLine($"  HyperlinksChanged: {document.HyperlinksChanged}");
        Output.WriteLine($"  HyperlinkBase: {document.HyperlinkBase}");
        Output.WriteLine($"  Template: {document.Template}");
        Output.WriteLine($"  Manager: {document.Manager}");
        Output.WriteLine($"  Company: {document.Company}");
        Output.WriteLine($"  PresentationFormat: {document.PresentationFormat}");
        Output.WriteLine($"  Application: {document.Application}");
        Output.WriteLine($"  ApplicationVersion: {document.ApplicationVersion}");

        Output.WriteLine($"  Pages: {document.Pages}");
        Output.WriteLine($"  Words: {document.Words}");
        Output.WriteLine($"  Characters: {document.Characters}");
        Output.WriteLine($"  CharactersWithSpaces: {document.CharactersWithSpaces}");
        Output.WriteLine($"  Lines: {document.Lines}");
        Output.WriteLine($"  Paragraphs: {document.Paragraphs}");
        Output.WriteLine($"  TotalTime: {document.TotalTime}");

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