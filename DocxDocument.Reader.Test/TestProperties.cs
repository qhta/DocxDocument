using System.Reflection;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Properties;

using Newtonsoft.Json;

using Qhta.Xml.Serialization;

using Formatting = Newtonsoft.Json.Formatting;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace DocxDocument.Reader.Test
{
  public class TestProperties : TestBase
  {
    protected string[] statisticPropElementsNames = new string[] { "TotalTime", "Characters", "CharactersWithSpaces",
      "HiddenSlides", "Lines", "MMClips", "Notes", "Pages", "Paragraphs", "Slides", "TotalTime", "Words" };
    protected string[] extraPropElementsNames = new string[] { "w14:docId", "w15:docId", "w14:conflictMode" };
    protected string[] notSettingsElementsNames = new string[] { "w14:docId", "w15:docId", "w14:conflictMode", "w:rsids" };

    [Test]
    public void TestNormalTemplateProperties()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestDocumentProperties()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestCustomProperties()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      TestReadProperties(filename, true);
    }

    [Test]
    public void TestSampleDocsProperties()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        TestReadProperties(filename);
    }

    public virtual DocumentModel.Properties.DocumentProperties TestReadProperties(string filename, bool showDetails = false)
    {
      WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count(), Is.GreaterThan(0), "Document properties count is 0");
      WriteLine($"  AllDocumentProperties = {document.Properties.Count()}");

      #region CoreDocumentProperties
      CoreProperties? coreDocumentProperties = document.Properties.CoreProperties;
      int origCorePropertiesCount = 0;
      int corePropertiesCount = 0;
      if (coreDocumentProperties != null)
      {
        var coreFilePropertiesPart = reader.WordprocessingDocument.PackageProperties;
        var coreFilePropertiesPartProperties = typeof(PackageProperties).GetProperties();
        foreach (var prop in coreFilePropertiesPartProperties)
        {
          if (prop.GetValue(coreFilePropertiesPart, new object[0]) != null)
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
            var documentProperty = document.Properties.GetProperty(prop.Name);
            if (documentProperty != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      #endregion

      #region ExtendedDocumentProperties
      ContentProperties? contentDocumentProperties = document.Properties.ContentProperties;
      StatisticProperties? statisticDocumentProperties = document.Properties.StatisticProperties;
      int contentPropertiesCount = 0;
      int statisticPropertiesCount = 0;
      int origExtendedPropertiesCount = 0;
      int origContentPropertiesCount = 0;
      int origStatisticPropertiesCount = 0;
      if (contentDocumentProperties != null)
      {
        origExtendedPropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Elements().Count() ?? 0;
        origStatisticPropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
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
            var documentProperty = document.Properties.GetProperty(prop.Name);
            if (documentProperty != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      #endregion

      #region CustomDocumentProperties
      CustomProperties? customDocumentProperties = document.Properties.CustomProperties;
      int customPropertiesCount = 0;
      int origCustomPropertiesCount = 0;
      if (customDocumentProperties != null)
      {
        customPropertiesCount = customDocumentProperties.Count();
        origCustomPropertiesCount = reader.WordprocessingDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
        WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in customDocumentProperties)
          {
            if (prop?.Name != null)
            {
              var documentProperty = document.Properties.GetProperty(prop.Name);
              if (documentProperty != null)
                WriteLine($"    {documentProperty}");
            }
          }
        }
      }
      #endregion

      #region DocumentSettings
      DocumentSettings? documentSettings = document.Properties.DocumentSettings;
      int origDocumentSettingsCount = 0;
      int documentSettingsCount = 0;
      if (documentSettings != null)
      {
        origDocumentSettingsCount = reader.WordprocessingDocument?.MainDocumentPart?.DocumentSettingsPart?.Settings?.Elements().Count() ?? 0;
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
            var documentProperty = document.Properties.GetProperty(prop.Name);
            if (documentProperty?.Value != null)
              WriteLine($"    {documentProperty}");
          }
        }
      }
      #endregion

      Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
      Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      Assert.That(statisticPropertiesCount, Is.EqualTo(origStatisticPropertiesCount), "Invalid content properties count");
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");
      Assert.That(documentSettingsCount, Is.EqualTo(origDocumentSettingsCount), "Invalid document settings count");

      return document.Properties;
    }

    //[Test]
    public void TestPropertiesJsonSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType);

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      var oldProperties = TestReadProperties(filename, true);
      var serializer = JsonSerializer.Create();
      var textWriter = new StringWriter();
      JsonSerializerSettings settings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, 
        /*TypeNameHandling = TypeNameHandling.All,*/ Formatting = Formatting.Indented };
      var str = JsonConvert.SerializeObject(oldProperties, settings);
      //var jsonWriter = new JsonTextWriter(textWriter) { Formatting = Formatting.Indented, NullValueHandling = false };
      //serializer.Serialize(jsonWriter, oldProperties);
      //string str = textWriter.ToString();
      WriteLine(str);
      WriteLine();

      var textReader = new StringReader(str);
      var jsonReader = new JsonTextReader(textReader);
      var newProperties = serializer.Deserialize<DocumentProperties>(jsonReader);
      Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      if (newProperties != null)
      {
        var oldPropertiesCount = oldProperties.Count();
        var newPropertiesCount = newProperties.Count();
        Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count was different from original");
        var newPropArray = newProperties.ToArray();
        var oldPropArray = newProperties.ToArray();
        for (int i = 0; i < oldPropertiesCount; i++)
          Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
      }
    }

    [Test]
    public void TestPropertiesXmlSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType);

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      var oldProperties = TestReadProperties(filename, true);
      var textWriter = new StringWriter();
      var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
        new SerializationOptions { AcceptAllProperties = true, });
      serializer.Serialize(textWriter, oldProperties);
      textWriter.Flush();
      string str = textWriter.ToString();
      WriteLine(str);
      WriteLine();

      var textReader = new StringReader(str);
      var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      var oldPropertiesCount = oldProperties.Count();
      var newPropertiesCount = newProperties.Count();
      Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
      var newPropArray = newProperties.ToArray();
      var oldPropArray = oldProperties.ToArray();
      for (int i = 0; i < oldPropertiesCount; i++)
        Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    }

  }
}