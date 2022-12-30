using System.Diagnostics;
using System.Reflection;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

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
      ProcessProperties(filename, true);
    }

    [Test]
    public void TestDocumentProperties()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      ProcessProperties(filename, true);
    }

    [Test]
    public void TestCustomProperties()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      ProcessProperties(filename, true);
    }

    [Test]
    public void TestSampleDocsProperties()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        ProcessProperties(filename);
    }

    public virtual DocumentModel.Properties.DocumentProperties ProcessProperties(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.AllDocumentProperties);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Properties, "No document properties read");
      Assert.That(document.Properties.Count(), Is.GreaterThan(0), "Document properties count is 0");
      TestContext.Progress.WriteLine($"  AllDocumentProperties = {document.Properties.Count()}");

      #region CoreDocumentProperties
      ExtendedProperties? coreDocumentProperties = document.Properties.CoreProperties;
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
        var coreProperties = typeof(ExtendedProperties).GetProperties();
        foreach (var prop in coreProperties.Where(item => item.CanWrite))
          if (prop.GetValue(coreDocumentProperties, null) != null)
            corePropertiesCount++;
        TestContext.Progress.WriteLine(
          $"  CoreProperties: defined {coreProperties.Count()} loaded {corePropertiesCount} expected {origCorePropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in coreProperties.Where(item => item.CanWrite))
          {
            var value = document.Properties.Get(prop.Name);
            if (value != null)
              TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
          }
        }
      }

      #endregion


      #region ContentDocumentProperties
      ExtendedProperties? contentDocumentProperties = document.Properties.ExtendedProperties;
      int contentPropertiesCount = 0;
      int origContentPropertiesCount = 0;
      if (contentDocumentProperties != null)
      {
        var origExtraFilePropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Count() ?? 0;
        var origStatisticPropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
          ?.Count(item => statisticPropElementsNames.Contains(item.LocalName)) ?? 0;
        var contentProperties = typeof(ExtendedProperties).GetProperties();
        origContentPropertiesCount = origExtraFilePropertiesCount;// - origStatisticPropertiesCount;
        foreach (var prop in contentProperties.Where(item => item.CanWrite))
        {
          if (prop.GetValue(contentDocumentProperties, null) != null)
            contentPropertiesCount++;
        }
        TestContext.Progress.WriteLine(
          $"  ContentProperties: defined {contentProperties.Count()} loaded {contentPropertiesCount} expected {origContentPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in contentProperties.Where(item => item.CanWrite))
          {
            var value = document.Properties.Get(prop.Name);
            if (value != null)
              TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
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
        TestContext.Progress.WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
        if (showDetails)
        {
          foreach (var prop in customDocumentProperties)
          {
            if (prop?.Name != null)
            {
              var value = document.Properties.Get(prop.Name);
              if (value != null)
                TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
            }
          }
        }
      }
      #endregion

      Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
      Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");

      return document.Properties;
    }

    //[Test]
    public void TestPropertiesJsonSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item => item.IsPublic && !item.IsGenericType);

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      var properties = ProcessProperties(filename, true);
      var serializer = JsonSerializer.Create();
      var textWriter = new StringWriter();
      var jsonWriter = new JsonTextWriter(textWriter) { Formatting = Formatting.Indented };
      serializer.Serialize(jsonWriter, properties);
      string str = textWriter.ToString();
      Debug.WriteLine(str);
      Debug.WriteLine("");
      TestContext.Out.WriteLine(str);
      TestContext.Out.WriteLine();

      var textReader = new StringReader(str);
      var jsonReader = new JsonTextReader(textReader);
      var newProperties = serializer.Deserialize<DocumentProperties>(jsonReader);
      Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      var propertiesCount = properties.Count();
      var newPropertiesCount = newProperties.Count();
      Assert.That(newPropertiesCount, Is.EqualTo(propertiesCount), $"Deserialized properties count different for original");
    }

    //[Test]
    public void TestPropertiesXmlSerialization()
    {
      var extraTypes = Assembly.Load("DocumentModel").GetTypes()
        .Where(item=>item.IsPublic && !item.IsGenericType);

      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      var properties = ProcessProperties(filename, true);
      var textWriter = new StringWriter();
      var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
        new SerializationOptions{ AcceptAllProperties = true, });
      serializer.Serialize(textWriter, properties);
      textWriter.Flush();
      string str = textWriter.ToString();
      Debug.WriteLine(str);
      Debug.WriteLine("");
      TestContext.Out.WriteLine(str);
      TestContext.Out.WriteLine();

      var textReader = new StringReader(str);
      var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
      Assert.IsNotNull(newProperties, $"Deserialized properties are null");
      var propertiesCount = properties.Count();
      var newPropertiesCount = newProperties.Count();
      Assert.That(newPropertiesCount, Is.EqualTo(propertiesCount), $"Deserialized properties count different for original");
    }

  }
}