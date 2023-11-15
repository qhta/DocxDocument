using System.Diagnostics;

using Qhta.TestUtilities;

namespace DocxDocument.Test;

public class ReadTest
{
  public TextWriter Output { [DebuggerStepThrough] get; set; } = null!;
  public string SamplesPath { [DebuggerStepThrough] get; set; } = null!;

  public void Initialize()
  {
    //Console.SetOut(ConsoleOutput);    // Associate StringBuilder with StdOut
    //this.ConsoleOutput.Clear();    // Clear text from any previous text runs
    SamplesPath = GetSamplesPath();
  }

  public bool TestOpenAllFiles()
  {
    bool success = false;
    var samplesPath = SamplesPath;
    foreach (var file in Directory.GetFiles(samplesPath, "*.docx").Where(name => !name.EndsWith(".new.docx")))
    {
      Output.WriteLine($"TestOpen: {file}");
      try
      {
        using (var document = DM.Document.Open(file, false))
          Output.WriteLine($"  Type: {document.DocumentType}");
        success = true;
      }
      catch (Exception ex)
      {
        Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
        success = false;
        break;
      }
    }
    return success;
  }

  public bool TestReadProperties()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentProperties.docx");
    return TestReadProperties(file);
  }

  public bool TestReadProperties(string file)
  {
    bool success = false;
    Output.WriteLine($"TestReadProperties: {file}");
    try
    {
      using (var document = DM.Document.Open(file, false))
      {
        Output.WriteLine($"  Title: {document.BuiltInProperties.Title}");
        Output.WriteLine($"  Creator: {document.BuiltInProperties.Creator}");
        Output.WriteLine($"  Created: {document.BuiltInProperties.Created}");
        Output.WriteLine($"  LastModifiedBy: {document.BuiltInProperties.LastModifiedBy}");
        Output.WriteLine($"  Modified: {document.BuiltInProperties.Modified}");
        Output.WriteLine($"  LastPrinted: {document.BuiltInProperties.LastPrinted}");
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

        //Output.WriteLine($"  DigitalSignature: {document.BuiltInProperties.DigitalSignature}");
        Output.WriteLine($"  TitlesOfParts: {document.BuiltInProperties.TitlesOfParts?.ToDumpString()}");
        Output.WriteLine($"  HeadingPairs: {document.BuiltInProperties.HeadingPairs?.ToDumpString()}");
        Output.WriteLine($"  HyperlinkList: {document.BuiltInProperties.HyperlinkList?.ToDumpString()}");
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

        if (document.CustomProperties != null)
          foreach (var item in document.CustomProperties)
          {
            var val = item.Value;
            Output.WriteLine($"  {item.Name}: {val.ToDumpString()}");
          }
        success = true;
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    return success;
  }

  public bool TestReadSettings()
  {
    var samplesPath = SamplesPath;
    var fileName = Path.Combine(samplesPath, "DocumentSettings.docx");
    return TestReadSettings(fileName);
  }

  public bool TestReadSettings(string fileName)
  {
    bool success = true;
    Output.WriteLine($"TestReadSettings: {fileName}");
    try
    {
      using (var document = DM.Document.Open(fileName, false))
      {
        if (document.HasDocumentSettings)
        {
          var settings = document.DocumentSettings;
          if (settings != null)
            foreach (var prop in settings.GetType().GetProperties()
              .Where(prop => prop.GetCustomAttribute<DataMemberAttribute>() != null).ToArray())
            {
              var val = prop.GetValue(settings);
              if (val != null)
              {
                success = false;
                Output.WriteLine($"  {prop.Name}: {val.ToDumpString()}");
              }
            }
        }
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
      success = false;
    }
    return success;
  }

  public bool CompareDocxFiles(string actualDocFile, string expectedDocFile)
  {
    bool success = false;
    Output.WriteLine($"Comparing docx files {Path.GetFileName(actualDocFile)} <-> {Path.GetFileName(expectedDocFile)}");
    try
    {
      using (var actualDocument = DM.Document.Open(actualDocFile, false))
      using (var expectedDocument = DM.Document.Open(expectedDocFile, false))
        success = CompareDocuments(actualDocument, expectedDocument);
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
      success = false;
    }
    return success;
  }

  public bool CompareDocuments(DM.Document actualDocument, DM.Document expectedDocument)
  {
    bool success = false;
    bool ok = DeepComparer.CompareObjects(actualDocument, expectedDocument);
    if (!ok)
    {
      var diffs = DeepComparer.Diffs;
      foreach (var diff in diffs)
      {
        Output.WriteLine($"{diff.ValuePath} {(diff.Reason ?? "are different")}");
        Output.WriteLine($"  actual:   {(diff.ActualValue?.ToDumpString() ?? "null")}");
        Output.WriteLine($"  expected: {(diff.ExpectedValue?.ToDumpString() ?? "null")}");
      }
    }
    else
    {
      Output.WriteLine($"Documents are equal");
      success = ok;
    }
    return success;
  }

  private string GetSamplesPath()
  {
    string result = Environment.CurrentDirectory!;
    while (!result.EndsWith(".Test"))
      result = Path.GetDirectoryName(result)!;
    result = Path.Combine(result, "Samples");
    return result;
  }

}