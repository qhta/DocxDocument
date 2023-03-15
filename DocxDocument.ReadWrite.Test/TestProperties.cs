using System.Reflection;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;

using Newtonsoft.Json;

using Qhta.Xml.Serialization;

using Formatting = Newtonsoft.Json.Formatting;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DocxDocument.Reader.Test
{
  /// <summary>
  /// Test of the document properties.
  /// </summary>
  /// <seealso cref="DocxDocument.Reader.Test.TestBase" />
  public class TestProperties : TestBase
  {
    /// <summary>
    /// Names of the extended properties that are treated as statistic properties.
    /// </summary>
    protected string[] statisticPropElementsNames { get; set; } = new string[] { "TotalTime", "Characters", "CharactersWithSpaces",
      "HiddenSlides", "Lines", "MMClips", "Notes", "Pages", "Paragraphs", "Slides", "TotalTime", "Words" };

    /// <summary>
    /// Names of the xml elements that are used over Office version 2007.
    /// </summary>
    protected string[] extraPropElementsNames { get; set; } = new string[] { "w14:docId", "w15:docId", "w14:conflictMode" };

    /// <summary>
    /// Names of the xml elements that are stored in the document settings part, but belong to document properies.
    /// </summary>
    protected string[] settingsPropertiesElementsNames { get; set; } = new string[] { "w14:docId", "w15:docId", "w14:conflictMode", "w:rsids" };

    /// <summary>
    /// Tests the read normal template properties.
    /// </summary>
    [Test]
    public void TestReadNormalTemplateProperties()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      TestReadProperties(filename, true);
    }

    /// <summary>
    /// Tests the document properties read from "DocumentProperties.docx" file.
    /// </summary>
    [Test]
    public void TestReadDocumentProperties()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      TestReadProperties(filename, true);
    }

    /// <summary>
    /// Tests the document properties read from "CustomProperties.docx" file.
    /// </summary>
    [Test]
    public void TestReadCustomProperties()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      TestReadProperties(filename, true);
    }

    /// <summary>
    /// Tests the document properties read from all docx files in folder specified by test path.
    /// </summary>
    [Test]
    public void TestReadSampleDocsProperties()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        TestReadProperties(filename);
    }

    /// <summary>
    /// Tests the document properties read from the file
    /// </summary>
    /// <param name="filename">The filename.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    public virtual void TestReadProperties(string filename, bool showDetails = false)
    {
      WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count(), Is.GreaterThan(0), "Document properties count is 0");
      WriteLine($"  AllDocumentProperties = {document.Properties.Count()}");

      CheckReadCoreDocumentProperties(document, reader.WordprocessingDocument, showDetails);

      CheckReadExtendedDocumentProperties(document, reader.WordprocessingDocument, showDetails);

      CheckReadCustomDocumentProperties(document, reader.WordprocessingDocument, showDetails);

      CheckReadDocumentSettings(document, reader.WordprocessingDocument, showDetails);

      CheckReadWebSettings(document, reader.WordprocessingDocument, showDetails);
    }

    /// <summary>
    /// Checks whether the core document properties read from the file are equal to origin ones.
    /// </summary>
    /// <param name="modelDocument">Model document read from docx fils.</param>
    /// <param name="origDocument">The original document.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    private void CheckReadCoreDocumentProperties(DocumentModel.Wordprocessing.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
    {
      CoreProperties? coreDocumentProperties = modelDocument.Properties?.CoreProperties;
      int origCorePropertiesCount = 0;
      int corePropertiesCount = 0;
      if (coreDocumentProperties != null)
      {
        var origFilePropertiesPart = origDocument.PackageProperties;
        var coreFilePropertiesPartProperties = typeof(PackageProperties).GetProperties();
        foreach (var prop in coreFilePropertiesPartProperties)
        {
          if (prop.GetValue(origFilePropertiesPart, new object[0]) != null)
            origCorePropertiesCount++;
        }
        var coreProperties = typeof(CoreProperties).GetProperties();
        foreach (var prop in coreProperties.Where(item => item.CanWrite))
          if (prop.GetValue(coreDocumentProperties, null) != null)
            corePropertiesCount++;
        WriteLine(
          $"  CoreProperties: defined {coreProperties.Count()} loaded {corePropertiesCount} expected {origCorePropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in coreProperties.Where(item => item.CanWrite))
          {
            var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
            if (documentProperty != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
    }

    /// <summary>
    /// Checks whether the extended document properties (content and statistic) read from the file are equal to origin ones.
    /// </summary>
    /// <param name="modelDocument">Model document read from docx fils.</param>
    /// <param name="origDocument">The original document.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    private void CheckReadExtendedDocumentProperties(DocumentModel.Wordprocessing.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
    {
      ContentProperties? contentDocumentProperties = modelDocument.Properties?.ContentProperties;
      StatisticProperties? statisticDocumentProperties = modelDocument.Properties?.StatisticProperties;
      int contentPropertiesCount = 0;
      int statisticPropertiesCount = 0;
      int origExtendedPropertiesCount = 0;
      int origContentPropertiesCount = 0;
      int origStatisticPropertiesCount = 0;
      if (contentDocumentProperties != null)
      {
        origExtendedPropertiesCount = origDocument.ExtendedFilePropertiesPart?.Properties?.Elements().Count() ?? 0;
        origStatisticPropertiesCount = origDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
          ?.Count(item => statisticPropElementsNames.Contains(item.LocalName)) ?? 0;
        origContentPropertiesCount = origExtendedPropertiesCount - origStatisticPropertiesCount;
        var contentProperties = typeof(ContentProperties).GetProperties();
        foreach (var prop in contentProperties.Where(item => item.CanWrite))
        {
          if (prop.GetValue(contentDocumentProperties, null) != null)
            contentPropertiesCount++;
        }
        var statisticProperties = typeof(StatisticProperties).GetProperties();
        foreach (var prop in statisticProperties.Where(item => item.CanWrite))
        {
          if (prop.GetValue(statisticDocumentProperties, null) != null)
            statisticPropertiesCount++;
        }
        WriteLine(
          $"  ContentProperties: defined {contentProperties.Count()} loaded {contentPropertiesCount} expected {origContentPropertiesCount}");
        WriteLine(
          $"  StatisticProperties: defined {statisticProperties.Count()} loaded {statisticPropertiesCount} expected {origStatisticPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in contentProperties.Where(item => item.CanWrite))
          {
            var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
            if (documentProperty != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      Assert.That(statisticPropertiesCount, Is.EqualTo(origStatisticPropertiesCount), "Invalid content properties count");
    }

    /// <summary>
    /// Checks whether the custom document properties read from the file are equal to origin ones.
    /// </summary>
    /// <param name="modelDocument">Model document read from docx fils.</param>
    /// <param name="origDocument">The original document.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    private void CheckReadCustomDocumentProperties(DocumentModel.Wordprocessing.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
    {
      CustomProperties? customDocumentProperties = modelDocument.Properties?.CustomProperties;
      int customPropertiesCount = 0;
      int origCustomPropertiesCount = 0;
      if (customDocumentProperties != null)
      {
        customPropertiesCount = customDocumentProperties.Count();
        origCustomPropertiesCount = origDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
        WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in customDocumentProperties)
          {
            if (prop?.Name != null)
            {
              var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
              if (documentProperty != null)
                WriteLine($"    {documentProperty}");
            }
          }
        }
      }
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");
    }

    /// <summary>
    /// Checks whether the document settings read from the file are equal to origin ones.
    /// </summary>
    /// <param name="modelDocument">Model document read from docx fils.</param>
    /// <param name="origDocument">The original document.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    private void CheckReadDocumentSettings(DocumentModel.Wordprocessing.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
    {
      var documentSettings = modelDocument.Properties?.DocumentSettings;
      int origDocumentSettingsCount = 0;
      int documentSettingsCount = 0;
      if (documentSettings != null)
      {
        origDocumentSettingsCount = origDocument.MainDocumentPart?.DocumentSettingsPart?.Settings?.Elements().Count() ?? 0;
        var modelDocumentSettings = typeof(DocumentSettings).GetProperties();
        foreach (var prop in modelDocumentSettings.Where(item => item.CanWrite))
          if (prop.GetValue(documentSettings, null) != null)
            documentSettingsCount++;
        WriteLine(
          $"  DocumentSettings: defined {modelDocumentSettings.Count()} loaded {documentSettingsCount} expected {origDocumentSettingsCount}");
        if (showDetails)
        {
          foreach (var prop in modelDocumentSettings.Where(item => item.CanWrite))
          {
            var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
            if (documentProperty?.Value != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      Assert.That(documentSettingsCount, Is.EqualTo(origDocumentSettingsCount), "Invalid document settings count");
    }

    /// <summary>
    /// Checks whether the web settings read from the file are equal to origin ones.
    /// </summary>
    /// <param name="modelDocument">Model document read from docx fils.</param>
    /// <param name="origDocument">The original document.</param>
    /// <param name="showDetails">Specifies if test details should be shown.</param>
    private void CheckReadWebSettings(DocumentModel.Wordprocessing.Document modelDocument, WordprocessingDocument origDocument, bool showDetails)
    {
      var webSettings = modelDocument.Properties?.WebSettings;
      int origWebSettingsCount = 0;
      int webSettingsCount = 0;
      if (webSettings != null)
      {
        origWebSettingsCount = origDocument.MainDocumentPart?.WebSettingsPart?.WebSettings?.Elements().Count() ?? 0;
        var modelWebSettings = typeof(DM.WebSettings).GetProperties();
        foreach (var prop in modelWebSettings.Where(item => item.CanWrite))
          if (prop.GetValue(webSettings, null) != null)
            webSettingsCount++;
        WriteLine(
          $"  WebSettings: defined {modelWebSettings.Count()} loaded {webSettingsCount} expected {origWebSettingsCount}");
        if (showDetails)
        {
          foreach (var prop in modelWebSettings.Where(item => item.CanWrite))
          {
            var documentProperty = modelDocument.Properties?.GetProperty(prop.Name);
            if (documentProperty?.Value != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      Assert.That(webSettingsCount, Is.EqualTo(origWebSettingsCount), "Invalid web settings count");
    }

    /// <summary>
    /// Tests properties Xml serialization by reading "CustomProperties.docx" file,
    /// serialize and deserialize properties using string writer.
    /// </summary>
    [Test]
    public void TestReadPropertiesXmlSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      WriteLine($"Testing properties of: {filename}");
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      var oldProperties = document.Properties;//TestReadProperties(filename, true);
      Assert.IsNotNull(oldProperties, "No document properties read");
      if (oldProperties == null)
        return;
      var textWriter = new StringWriter();
      var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
        new SerializationOptions { AcceptAllProperties = true });
      try
      {
        serializer.Serialize(textWriter, oldProperties);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      textWriter.Flush();
      string str = textWriter.ToString();
      WriteLine(str);
      WriteLine();

      var textReader = new StringReader(str);
      var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      var diffs = new DiffList();
      var ok = DeepComparer.IsEqual(oldProperties, newProperties, diffs);
      if (!ok)
        foreach (var diff in diffs)
          WriteLine(diff.ToString());
      Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
    }

    //[Test]
    //public void TestUpdatePropertiesWithXmlSerialization()
    //{
    //  var extraTypes = Assembly.Load("DocumentModel").GetTypes()
    //    .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    //  var filename = Path.Combine(TestPath, "CustomProperties.docx");
    //  var reader = new DocxReader(filename);
    //  var document = reader.ReadDocument(Parts.AllDocumentProperties);
    //  var oldProperties = document.Properties;//TestReadProperties(filename, true);
    //  Assert.IsNotNull(oldProperties, "No document properties read");
    //  if (oldProperties == null)
    //    return;


    //  var textWriter = new StringWriter();
    //  var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
    //    new SerializationOptions { AcceptAllProperties = true });
    //  serializer.Serialize(textWriter, oldProperties);
    //  textWriter.Flush();
    //  string str = textWriter.ToString();
    //  WriteLine(str);
    //  WriteLine();

    //  var textReader = new StringReader(str);
    //  var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
    //  Assert.IsNotNull(newProperties, $"Deserialized properties are null");
    //  var oldPropertiesCount = oldProperties.Count();
    //  var newPropertiesCount = newProperties.Count();
    //  var newPropArray = newProperties.ToArray();
    //  var oldPropArray = oldProperties.ToArray();
    //  for (int i = 0; i < Math.Min(oldPropertiesCount, newPropertiesCount); i++)
    //  {
    //    if (newPropArray[i].Name == "HeadingPairs")
    //      Debug.Assert(true);
    //    Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    //  }
    //  Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
    //}

  }
}