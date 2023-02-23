using System.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

using Qhta.Xml.Serialization;

namespace DocxDocument.Reader.Test;

public class TestNumberingDefinitions : TestBase
{

  [Test]
  public void TestNormalTemplateNumbering()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadNumbering(filename, true);
  }

  [Test]
  public void TestDocumentNumbering()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadNumbering(filename, true);
  }

  [Test]
  public void TestCustomNumbering()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadNumbering(filename, true);
  }

  [Test]
  public void TestSampleDocsNumbering()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadNumbering(filename);
  }

  public virtual DMW.Numbering ReadNumbering(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.NumberingDefinitions);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Numbering, "No document numbering read");
    var modelNumbering = document.Numbering;
    var modelAbstractNumbering = document.Numbering.AbstractNums;
    int modelAbstractNumberingCount = modelAbstractNumbering?.Count ?? 0;
    var origNumbering = reader.WordprocessingDocument.MainDocumentPart?.NumberingDefinitionsPart?.Numbering;
    var diffs = new DiffList();
    if (!NumberingConverter.CompareModelElement(origNumbering, modelNumbering, diffs, null))
      Assert.Fail(diffs.FirstOrDefault()?.ToString());

    var origAbstractNumbering = origNumbering?.Elements<DXW.AbstractNum>();
    int origAbstractNumberingCount = origAbstractNumbering?.Count() ?? 0;
    WriteLine($"  Document Defined Numbering: found {modelAbstractNumberingCount}, expected {origAbstractNumberingCount}");
    Assert.That(modelAbstractNumberingCount, Is.EqualTo(origAbstractNumberingCount), "Invalid abstract Numbering count");

    var modelNumberingInstances = document.Numbering.NumberingInstances;
    int modelNumberingInstancesCount = modelNumberingInstances?.Count ?? 0;
    var origNumberingInstances = origNumbering?.Elements<DXW.NumberingInstance>();
    int origNumberingInstancesCount = origNumberingInstances?.Count() ?? 0;
    Assert.That(modelNumberingInstancesCount, Is.EqualTo(origNumberingInstancesCount), "Invalid numbering instances count");

    return document.Numbering;
  }

  [Test]
  public void TestNumberingXmlSerialization()
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.StyleDefinitions);
    DMW.Numbering oldNumbering = document.Numbering ?? new DMW.Numbering();//TestReadProperties(filename, true);
    Assert.IsNotNull(oldNumbering, "No document Numbering read");
    if (oldNumbering == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(Numbering), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldNumbering);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    //var textReader = new StringReader(str);
    //var newProperties = (DocumentProperties?)serializer.Deserialize(textReader);
    //Assert.IsNotNull(newProperties, $"Deserialized properties are null");
    //var oldPropertiesCount = oldNumbering.Count;
    //var newPropertiesCount = newProperties.Count();
    //var newPropArray = newProperties.ToArray();
    //var oldPropArray = oldNumbering.ToArray();
    //for (int i = 0; i < Math.Min(oldPropertiesCount, newPropertiesCount); i++)
    //{
    //  if (newPropArray[i].Name == "HeadingPairs")
    //    Debug.Assert(true);
    //  Assert.That(newPropArray[i], Is.EqualTo(oldPropArray[i]), $"Deserialized property \"{newPropArray[i].Name}\" different for original");
    //}
    //Assert.That(newPropertiesCount, Is.EqualTo(oldPropertiesCount), $"Deserialized properties count different for original");
  }

}
