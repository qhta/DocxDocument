using DocumentModel.Wordprocessing;

using Qhta.Xml.Serialization;
using System.Reflection;

namespace DocxDocument.Reader.Test;

public class TestFonts : TestBase
{

  [Test]
  public void TestNormalTemplateFonts()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestDocumentFonts()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestCustomFonts()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadFonts(filename, true);
  }

  [Test]
  public void TestSampleDocsFonts()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadFonts(filename);
  }

  public virtual DMW.Fonts ReadFonts(string filename, bool showDetails = false)
  {
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.FontTable);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Fonts, "No document fonts read");
    var modelFonts = document.Fonts;
    int modelFontsCount = modelFonts?.Count() ?? 0;
    var origFonts = reader.WordprocessingDocument.MainDocumentPart?.FontTablePart?.Fonts;
    int origFontsCount = origFonts?.Elements<DXW.Font>().Count() ?? 0;
    var diffs = new DMX.DiffList();
    var ok = DMXW.FontsConverter.CompareModelElement(origFonts, modelFonts, diffs, null);
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());

    return document.Fonts;
  }

  [Test]
  public void TestFontsXmlSerialization()
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.FontTable);
    var oldFonts = document.Fonts ?? new();
    Assert.IsNotNull(oldFonts, "No document fonts read");
    if (oldFonts == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMW.Fonts), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldFonts);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    var textReader = new StringReader(str);
    var newFonts = (Fonts?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newFonts, $"Deserialized fonts are null");
    var oldFontsCount = oldFonts.Count;
    var newFontsCount = newFonts.Count();
    var newFontsArray = newFonts.ToArray();
    var oldFontsArray = oldFonts.ToArray();
    for (int i = 0; i < Math.Min(oldFontsCount, newFontsCount); i++)
    {
      var oldItem = oldFontsArray[i];
      var newItem = newFontsArray[i];
      Assert.That(newItem, Is.EqualTo(oldItem), $"Deserialized font \"{newItem.Name}\" is different from original");
    }
    Assert.That(newFontsCount, Is.EqualTo(oldFontsCount), $"Deserialized fonts count is different from original");
  }

}
