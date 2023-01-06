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
  public class TestStyles : TestBase
  {

    [Test]
    public void TestNormalTemplateStyles()
    {
      var filename = Path.Combine(TestPath, "Normal.dotm");
      ReadStyles(filename, true);
    }

    [Test]
    public void TestDocumentStyles()
    {
      var filename = Path.Combine(TestPath, "DocumentProperties.docx");
      ReadStyles(filename, true);
    }

    [Test]
    public void TestCustomStyles()
    {
      var filename = Path.Combine(TestPath, "CustomProperties.docx");
      ReadStyles(filename, true);
    }

    [Test]
    public void TestSampleDocsStyles()
    {
      foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
        ReadStyles(filename);
    }

    public virtual DocumentModel.Wordprocessing.Styles ReadStyles(string filename, bool showDetails = false)
    {
      TestContext.Progress.WriteLine(filename);
      var reader = new DocxReader(filename);
      var document = reader.ReadDocument(Parts.StyleDefinitions);
      Assert.IsNotNull(document, "No document read");
      Assert.IsNotNull(document.Styles, "No document styles read");
      //Assert.That(document.Properties.Count(), Is.GreaterThan(0), "Document properties count is 0");
      //TestContext.Progress.WriteLine($"  AllDocumentProperties = {document.Properties.Count()}");

      //#region CoreDocumentProperties
      //CoreProperties? coreDocumentProperties = document.Properties.CoreProperties;
      //int origCorePropertiesCount = 0;
      //int corePropertiesCount = 0;
      //if (coreDocumentProperties != null)
      //{
      //  var coreFilePropertiesPart = reader.WordprocessingDocument.PackageProperties;
      //  var coreFilePropertiesPartProperties = typeof(PackageProperties).GetProperties();
      //  foreach (var prop in coreFilePropertiesPartProperties)
      //  {
      //    if (prop.GetValue(coreFilePropertiesPart, new object[0]) != null)
      //      origCorePropertiesCount++;
      //  }
      //  var coreProperties = typeof(CoreProperties).GetProperties();
      //  foreach (var prop in coreProperties.Where(item => item.CanWrite))
      //    if (prop.GetValue(coreDocumentProperties, null) != null)
      //      corePropertiesCount++;
      //  TestContext.Progress.WriteLine(
      //    $"  CoreProperties: defined {coreProperties.Count()} loaded {corePropertiesCount} expected {origCorePropertiesCount}");
      //  if (showDetails)
      //  {
      //    foreach (var prop in coreProperties.Where(item => item.CanWrite))
      //    {
      //      var value = document.Properties.Get(prop.Name);
      //      if (value != null)
      //        TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
      //    }
      //  }
      //}

      //#endregion

      //#region ContentDocumentProperties
      //ExtendedProperties? contentDocumentProperties = document.Properties.ExtendedProperties;
      //int contentPropertiesCount = 0;
      //int origContentPropertiesCount = 0;
      //if (contentDocumentProperties != null)
      //{
      //  var origExtraFilePropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Count() ?? 0;
      //  var origStatisticPropertiesCount = reader.WordprocessingDocument.ExtendedFilePropertiesPart?.Properties?.Elements()
      //    ?.Count(item => statisticPropElementsNames.Contains(item.LocalName)) ?? 0;
      //  var contentProperties = typeof(ExtendedProperties).GetProperties();
      //  origContentPropertiesCount = origExtraFilePropertiesCount;// - origStatisticPropertiesCount;
      //  foreach (var prop in contentProperties.Where(item => item.CanWrite))
      //  {
      //    if (prop.GetValue(contentDocumentProperties, null) != null)
      //      contentPropertiesCount++;
      //  }
      //  TestContext.Progress.WriteLine(
      //    $"  ContentProperties: defined {contentProperties.Count()} loaded {contentPropertiesCount} expected {origContentPropertiesCount}");
      //  if (showDetails)
      //  {
      //    foreach (var prop in contentProperties.Where(item => item.CanWrite))
      //    {
      //      var value = document.Properties.Get(prop.Name);
      //      if (value != null)
      //        TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
      //    }
      //  }
      //}

      //#endregion

      //#region CustomDocumentProperties
      //CustomProperties? customDocumentProperties = document.Properties.CustomProperties;
      //int customPropertiesCount = 0;
      //int origCustomPropertiesCount = 0;
      //if (customDocumentProperties != null)
      //{
      //  customPropertiesCount = customDocumentProperties.Count();
      //  origCustomPropertiesCount = reader.WordprocessingDocument?.CustomFilePropertiesPart?.Properties.Count() ?? 0;
      //  TestContext.Progress.WriteLine($"  CustomProperties = {customPropertiesCount}/{origCustomPropertiesCount}");
      //  if (showDetails)
      //  {
      //    foreach (var prop in customDocumentProperties)
      //    {
      //      if (prop?.Name != null)
      //      {
      //        var value = document.Properties.Get(prop.Name);
      //        if (value != null)
      //          TestContext.Progress.WriteLine($"    {prop.Name} = {value}");
      //      }
      //    }
      //  }
      //}
      //#endregion

      //Assert.That(corePropertiesCount, Is.EqualTo(origCorePropertiesCount), "Invalid core properties count");
      //Assert.That(contentPropertiesCount, Is.EqualTo(origContentPropertiesCount), "Invalid content properties count");
      //Assert.That(customPropertiesCount, Is.EqualTo(origCustomPropertiesCount), "Invalid custom properties count");

      return document.Styles;
    }

    //[Test]
    //public void TestPropertiesXmlSerialization()
    //{
    //  var extraTypes = Assembly.Load("DocumentModel").GetTypes()
    //    .Where(item=>item.IsPublic && !item.IsGenericType);

    //  var filename = Path.Combine(TestPath, "CustomProperties.docx");
    //  var oldProperties = ReadStyles(filename, true);
    //  var textWriter = new StringWriter();
    //  var serializer = new QXmlSerializer(typeof(DocumentProperties), extraTypes.ToArray(),
    //    new SerializationOptions{ AcceptAllProperties = true, });
    //  serializer.Serialize(textWriter, oldProperties);
    //  textWriter.Flush();
    //  string str = textWriter.ToString();
    //  Debug.WriteLine(str);
    //  Debug.WriteLine("");
    //  TestContext.Out.WriteLine(str);
    //  TestContext.Out.WriteLine();

    //  var textReader = new StringReader(str);
    //  var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
    //  Assert.IsNotNull(newProperties, $"Deserialized properties are null");
    //  var oldPropertiesCount = oldProperties.Count();
    //  var newPropertiesCount = newProperties.Count();
    //  Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
    //  var newPropArray = newProperties.ToArray();
    //  var oldPropArray = newProperties.ToArray();
    //  for (int i=0; i<oldPropertiesCount; i++)
    //    Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    //}

  }
}