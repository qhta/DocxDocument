using DocumentModel.Wordprocessing;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document numbering.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestNumbering : TestBase
{

  /// <summary>
  /// Tests the normal template numbering.
  /// </summary>
  [Test]
  public void TestNormalTemplateNumbering()
  {
    var filename = Path.Combine(TestPath, "Value.dotm");
    TestReadNumbering(filename, true);
  }

  /// <summary>
  /// Tests the numbering read from "DocumentProperties.docx" file.
  /// </summary>
  [Test]
  public void TestReadDocumentPropertiesNumbering()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadNumbering(filename, false);
  }

  /// <summary>
  /// Tests the numbering read from "CustomProperties.docx" file.
  /// </summary>
  [Test]
  public void TestReadCustomPropertiesNumbering()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    TestReadNumbering(filename, true);
  }

  /// <summary>
  /// Tests the numbering read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadNumbering()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadNumbering(filename);
  }

  /// <summary>
  /// Tests the numbering read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadNumbering(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing read numbering of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.NumberingDefinitions);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Numbering, "No document numbering read");
    var modelNumbering = document.Numbering;
    var origNumbering = reader.WordprocessingDocument.MainDocumentPart?.NumberingDefinitionsPart?.Numbering;
    var diffs = new DiffList();
    var ok = DMXW.NumberingConverter.CompareModelElement(origNumbering, modelNumbering, diffs, null);
    if (!ok && showDetails)
    {
      WriteLine("Read numbering differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }

  /// <summary>
  /// Tests numbering Xml serialization by reading files,
  /// serialize and deserialize numbering using string writer.
  /// </summary>
  [Test]
  public void TestReadNumberingXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadNumberingXmlSerialization(filename);
  }

  /// <summary>
  /// Tests numbering Xml serialization by reading file,
  /// serialize and deserialize numbering using string writer.
  /// </summary>
  public void TestReadNumberingXmlSerialization(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing numbering serialization of: {filename}");
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.NumberingDefinitions);
    var oldNumbering = document.Numbering ?? new();
    Assert.IsNotNull(oldNumbering, "No document numbering read");
    if (oldNumbering == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMW.Numbering), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldNumbering);
    textWriter.Flush();
    string str = textWriter.ToString();
    if (showDetails)
    {
      WriteLine(str);
      WriteLine();
    }

    var textReader = new StringReader(str);
    var newNumbering = (Numbering?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newNumbering, $"Deserialized numbering are null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldNumbering, newNumbering, diffs);
    if (!ok && showDetails)
    {
      WriteLine("Read numbering differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }


}
