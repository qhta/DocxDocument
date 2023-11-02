using System.Collections;
using System.Reflection;
using System.Runtime.Serialization;

using DocumentModel;
using DocumentModel.Utils;

using Qhta.TypeUtils;

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
  public void TestOpenAllFiles()
  {
    var samplesPath = SamplesPath;
    foreach (var file in Directory.GetFiles(samplesPath, "*.docx").Where(name=>!name.EndsWith(".new.docx")))
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
    TestReadProperties(file);
  }
  public void TestReadProperties(string file)
  {
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

        if (document.CustomProperties != null)
          foreach (var item in document.CustomProperties)
            Output.WriteLine($"  {item.Name}: {item.Value}");
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
  }

  public void TestCompareProperties(DM.Document checkedDocument, DM.Document expectedDocument)
  {
    var ok = true;
    if (!CompareProperty("DocumentType", checkedDocument.DocumentType, expectedDocument.DocumentType)) ok = false;
    if (!CompareProperty("Title", checkedDocument.BuiltInProperties.Title, expectedDocument.BuiltInProperties.Title)) ok = false;
    if (!CompareProperty("Creator", checkedDocument.BuiltInProperties.Creator, expectedDocument.BuiltInProperties.Creator)) ok = false;
    if (!CompareProperty("Created", checkedDocument.BuiltInProperties.Created, expectedDocument.BuiltInProperties.Created)) ok = false;
    if (!CompareProperty("LastModifiedBy", checkedDocument.BuiltInProperties.LastModifiedBy, expectedDocument.BuiltInProperties.LastModifiedBy)) ok = false;
    if (!CompareProperty("Modified", checkedDocument.BuiltInProperties.Modified, expectedDocument.BuiltInProperties.Modified)) ok = false;
    if (!CompareProperty("LastPrinted", checkedDocument.BuiltInProperties.LastPrinted, expectedDocument.BuiltInProperties.LastPrinted)) ok = false;
    if (!CompareProperty("Subject", checkedDocument.BuiltInProperties.Subject, expectedDocument.BuiltInProperties.Subject)) ok = false;
    if (!CompareProperty("Revision", checkedDocument.BuiltInProperties.Revision, expectedDocument.BuiltInProperties.Revision)) ok = false;
    if (!CompareProperty("Language", checkedDocument.BuiltInProperties.Language, expectedDocument.BuiltInProperties.Language)) ok = false;
    if (!CompareProperty("Keywords", checkedDocument.BuiltInProperties.Keywords, expectedDocument.BuiltInProperties.Keywords)) ok = false;
    if (!CompareProperty("CoreIdentifier", checkedDocument.BuiltInProperties.Identifier, expectedDocument.BuiltInProperties.Identifier)) ok = false;
    if (!CompareProperty("ContentType", checkedDocument.BuiltInProperties.ContentType, expectedDocument.BuiltInProperties.ContentType)) ok = false;
    if (!CompareProperty("ContentStatus", checkedDocument.BuiltInProperties.ContentStatus, expectedDocument.BuiltInProperties.ContentStatus)) ok = false;
    if (!CompareProperty("Category", checkedDocument.BuiltInProperties.Category, expectedDocument.BuiltInProperties.Category)) ok = false;
    if (!CompareProperty("Description", checkedDocument.BuiltInProperties.Description, expectedDocument.BuiltInProperties.Description)) ok = false;
    if (!CompareProperty("Version", checkedDocument.BuiltInProperties.Version, expectedDocument.BuiltInProperties.Version)) ok = false;

    //Output.WriteLine($"  DigitalSignature: {document.BuiltInProperties.DigitalSignature}");
    if (!CompareProperty("TitlesOfParts", checkedDocument.BuiltInProperties.TitlesOfParts, expectedDocument.BuiltInProperties.TitlesOfParts)) ok = false;
    if (!CompareProperty("HeadingPairs", checkedDocument.BuiltInProperties.HeadingPairs, expectedDocument.BuiltInProperties.HeadingPairs)) ok = false;
    if (!CompareProperty("HyperlinkList", checkedDocument.BuiltInProperties.HyperlinkList, expectedDocument.BuiltInProperties.HyperlinkList)) ok = false;
    if (!CompareProperty("DocumentSecurity", checkedDocument.BuiltInProperties.DocumentSecurity, expectedDocument.BuiltInProperties.DocumentSecurity)) ok = false;
    if (!CompareProperty("ScaleCrop", checkedDocument.BuiltInProperties.ScaleCrop, expectedDocument.BuiltInProperties.ScaleCrop)) ok = false;
    if (!CompareProperty("LinksUpToDate", checkedDocument.BuiltInProperties.LinksUpToDate, expectedDocument.BuiltInProperties.LinksUpToDate)) ok = false;
    if (!CompareProperty("SharedDocument", checkedDocument.BuiltInProperties.SharedDocument, expectedDocument.BuiltInProperties.SharedDocument)) ok = false;
    if (!CompareProperty("HyperlinksChanged", checkedDocument.BuiltInProperties.HyperlinksChanged, expectedDocument.BuiltInProperties.HyperlinksChanged)) ok = false;
    if (!CompareProperty("HyperlinkBase", checkedDocument.BuiltInProperties.HyperlinkBase, expectedDocument.BuiltInProperties.HyperlinkBase)) ok = false;
    if (!CompareProperty("Template", checkedDocument.BuiltInProperties.Template, expectedDocument.BuiltInProperties.Template)) ok = false;
    if (!CompareProperty("Manager", checkedDocument.BuiltInProperties.Manager, expectedDocument.BuiltInProperties.Manager)) ok = false;
    if (!CompareProperty("Company", checkedDocument.BuiltInProperties.Company, expectedDocument.BuiltInProperties.Company)) ok = false;
    if (!CompareProperty("PresentationFormat", checkedDocument.BuiltInProperties.PresentationFormat, expectedDocument.BuiltInProperties.PresentationFormat)) ok = false;
    if (!CompareProperty("Application", checkedDocument.BuiltInProperties.Application, expectedDocument.BuiltInProperties.Application)) ok = false;
    if (!CompareProperty("ApplicationVersion", checkedDocument.BuiltInProperties.ApplicationVersion, expectedDocument.BuiltInProperties.ApplicationVersion)) ok = false;

    if (!CompareProperty("Pages", checkedDocument.BuiltInProperties.Pages, expectedDocument.BuiltInProperties.Pages)) ok = false;
    if (!CompareProperty("Words", checkedDocument.BuiltInProperties.Words, expectedDocument.BuiltInProperties.Words)) ok = false;
    if (!CompareProperty("Characters", checkedDocument.BuiltInProperties.Characters, expectedDocument.BuiltInProperties.Characters)) ok = false;
    if (!CompareProperty("CharactersWithSpaces", checkedDocument.BuiltInProperties.CharactersWithSpaces, expectedDocument.BuiltInProperties.CharactersWithSpaces)) ok = false;
    if (!CompareProperty("Lines", checkedDocument.BuiltInProperties.Lines, expectedDocument.BuiltInProperties.Lines)) ok = false;
    if (!CompareProperty("Paragraphs", checkedDocument.BuiltInProperties.Paragraphs, expectedDocument.BuiltInProperties.Paragraphs)) ok = false;
    if (!CompareProperty("TotalTime", checkedDocument.BuiltInProperties.TotalTime, expectedDocument.BuiltInProperties.TotalTime)) ok = false;

    if (!CompareProperty("CustomProperties", checkedDocument.CustomProperties, expectedDocument.CustomProperties)) ok = false;

    if (!ok)
      throw new Exception($"Test failed");
  }

  private bool CompareProperty(string propertyName, object? checkedValue, object? expectedValue)
  {
    if (checkedValue != null || expectedValue != null)
    {
      if (!object.Equals(checkedValue, expectedValue))
      {
        if (!CompareDeep(checkedValue, expectedValue, propertyName))
        {
          Output.WriteLine($"  {propertyName} is different:");
          Output.WriteLine($"    checked  value={checkedValue?.ToDumpString()}");
          Output.WriteLine($"    expected value={expectedValue.ToDumpString()}");
          return false;
        }
      }
    }
    return true;
  }

  private bool CompareDeep(object? checkedValue, object? expectedValue, string? propertyName = null)
  {
    if (checkedValue != null && expectedValue != null)
    {
      var checkedType = checkedValue.GetType();
      var expectedType = expectedValue.GetType();
      if (checkedType != expectedType)
      {
        if (propertyName != null)
          Output.WriteLine($"  {propertyName} types are different:");
        Output.WriteLine($"    checked  value type is {checkedValue.GetType()}");
        Output.WriteLine($"    expected value type is {expectedValue.GetType()}");
        return false;
      }
      var canCheck = false;
      var props = checkedType.GetProperties().Where(prop => prop.GetCustomAttribute<DataMemberAttribute>() != null).ToArray();
      if (props.Length > 0)
      {
        canCheck = true;
        foreach (var prop in props)
        {
          var val1 = prop.GetValue(checkedValue);
          var val2 = prop.GetValue(expectedValue);
          if (!CompareProperty(prop.Name, val1, val2))
            return false;
        }
      }
      if (checkedType.IsEnumerable())
      {
        var enumIntf1 = checkedValue as IEnumerable;
        var enumIntf2 = expectedValue as IEnumerable;
        if (enumIntf1 != null && enumIntf2 != null)
        {
          var enumerator1 = enumIntf1.GetEnumerator();
          var enumerator2 = enumIntf2.GetEnumerator();
          if (enumerator1 != null && enumerator2 != null)
          {
            canCheck = true;
            enumerator1.Reset();
            enumerator2.Reset();
            int n = 0;
            while (enumerator1.MoveNext() && enumerator2.MoveNext())
            {
              var item1 = enumerator1.Current;
              var item2 = enumerator2.Current;
              if (!CompareProperty($"item[{n}]", item1, item2))
                return false;
            }
            if (enumerator1.MoveNext() != enumerator2.MoveNext())
            {
              Output.WriteLine($"    unequal items count");
            }
          }
        }
      }
      if (!canCheck)
      {
        Output.WriteLine($"    checked  value type {checkedValue.GetType()} has no DataMember properties");
        return false;
      }

    }
    return true;
  }

  [TestMethod]
  public void TestReadSettings()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentSettings.docx");
    Output.WriteLine($"TestReadSettings: {file}");
    try
    {
      using (var document = DM.Document.Open(file, false))
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
  //    using (var document = DM.Document.Create(file, false))
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
    result = Path.Combine(result, "Samples");
    return result;
  }

}