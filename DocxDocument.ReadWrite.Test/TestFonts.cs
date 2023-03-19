using DocumentModel.Wordprocessing;

using Qhta.Xml.Serialization;
using System.Reflection;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document font table.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestFonts : TestBase
{

  /// <summary>
  /// Tests the normal template fonts.
  /// </summary>
  [Test]
  public void TestNormalTemplateFonts()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    TestReadFonts(filename, true);
  }

  /// <summary>
  /// Tests the fonts read from "DocumentProperties.docx" file.
  /// </summary>
  [Test]
  public void TestReadDocumentFonts()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    TestReadFonts(filename, true);
  }

  /// <summary>
  /// Tests the fonts read from "CustomProperties.docx" file.
  /// </summary>
  [Test]
  public void TestReadCustomFonts()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    TestReadFonts(filename, true);
  }

  /// <summary>
  /// Tests the fonts read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadSampleDocsFonts()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadFonts(filename);
  }

  /// <summary>
  /// Tests the fonts read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadFonts(string filename, bool showDetails = false)
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
    var diffs = new DiffList();
    var ok = DMXW.FontsConverter.CompareModelElement(origFonts, modelFonts, diffs, null);
    if (!ok && showDetails)
    {
      WriteLine("Read fonts differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }

  /// <summary>
  /// Tests fonts Xml serialization by reading "CustomProperties.docx" file,
  /// serialize and deserialize fonts using string writer.
  /// </summary>
  [Test]
  public void TestReadFontsXmlSerialization()
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
