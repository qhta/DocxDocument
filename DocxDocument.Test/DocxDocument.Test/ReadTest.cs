using DocumentModel.Utils;

using DMW = DocumentModel.Wordprocessing;

namespace DocxDocument.Test;

[TestClass]
public class ReadTest
{
  public TextWriter Output { get; set; } = null!;
  public string SamplesPath { get; set; } = null!;

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
        using (var document = DMW.Document.Open(file, false))
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
    TestReadProperties(file);
  }
  public void TestReadProperties(string file)
  {
    Output.WriteLine($"TestReadProperties: {file}");
    try
    {
      using (var document = DMW.Document.Open(file, false))
      {
        Output.WriteLine($"  Title: {document.BuiltInProperties.Title}");
        Output.WriteLine($"  CreatedBy: {document.BuiltInProperties.Creator}");
        Output.WriteLine($"  CreatedAt: {document.BuiltInProperties.Created}");
        Output.WriteLine($"  LastModifiedBy: {document.BuiltInProperties.LastModifiedBy}");
        Output.WriteLine($"  LastModifiedAt: {document.BuiltInProperties.Modified}");
        Output.WriteLine($"  LastPrintedAt: {document.BuiltInProperties.LastPrinted}");
        Output.WriteLine($"  Subject: {document.BuiltInProperties.Subject}");
        Output.WriteLine($"  Revision: {document.BuiltInProperties.Revision}");
        Output.WriteLine($"  Language: {document.BuiltInProperties.Language}");
        Output.WriteLine($"  Keywords: {document.BuiltInProperties.Keywords}");
        Output.WriteLine($"  CoreIdentifier: {document.BuiltInProperties.Identifier}");
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

  [TestMethod]
  public void TestReadSettings()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentSettings.docx");
    Output.WriteLine($"TestReadSettings: {file}");
    try
    {
      using (var document = DMW.Document.Open(file, false))
      {
        if (document.HasDocumentSettings)
        {
          var settings = document.DocumentSettings;
          //settings.IgnoreUnknown = true;
          foreach (var item in settings)
          {
            var val = item.Value;
            Output.WriteLine($"  {item.Name}: {DocumentModel.TestUtilities.ToDumpString(val)}");
          }
        }
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
  }

  //[TestMethod]
  //public void TestReadWriteSettings()
  //{
  //  var samplesPath = SamplesPath;
  //  var file = Path.Combine(samplesPath, "Temp.docx");
  //  Output.WriteLine($"TestReadWriteSettings: {file}");
  //  try
  //  {
  //    using (var document = DMW.Document.Create(file, false))
  //    {
  //      if (document.HasDocumentSettings)
  //      {
  //        var settings = document.DocumentSettings;
  //        //settings.IgnoreUnknown = true;
  //        foreach (var item in settings)
  //        {
  //          var val = item.Value;
  //          Output.WriteLine($"  {item.Name}: {DocumentModel.TestUtilities.ToDumpString(val)}");
  //        }
  //      }
  //    }
  //  }
  //  catch (Exception ex)
  //  {
  //    Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
  //  }
  //}

  private string GetSamplesPath()
  {
    string result = Environment.CurrentDirectory!;
    while (!result.EndsWith(".Test"))
      result = Path.GetDirectoryName(result)!;
    result = Path.Combine(result,"Samples");
    return result;
  }

}