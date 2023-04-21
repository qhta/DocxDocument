using DocumentModel.OpenXml.Drawings;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document Background part.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestBackground : TestBase
{

  /// <summary>
  /// Tests the Background read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadBackground()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "Background*.docx"))
      TestReadBackground(filename);
  }

  /// <summary>
  /// Tests the Background read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadBackground(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing background read of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Background);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Background, "No document Background read");
    var modelBackground = document.Background;
    var originBackground = reader.WordprocessingDocument.MainDocumentPart?.Document?.DocumentBackground;

    var diffs = new DiffList();
    if (!DMXW.DocumentBackgroundConverter.CompareModelElement(originBackground, modelBackground, diffs, null))
    {
      if (showDetails)
      {
        WriteLine("Read Background differences found:");
        foreach (var diff in diffs)
          WriteLine(diff.ToString());
      }
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
    }
  }

  /// <summary>
  /// Tests the Background read from all Background*.docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadBackgroundXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "Background*.docx"))
      TestReadBackgroundXmlSerialization(filename);
  }

  /// <summary>
  /// Tests Background Xml serialization by reading a specified file,
  /// serialize and deserialize Background using string writer.
  /// </summary>
  public void TestReadBackgroundXmlSerialization(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing background serialization of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Background);
    DMW.DocumentBackground oldBackground = document.Background ?? new DMW.DocumentBackground();
    Assert.IsNotNull(oldBackground, "No document Background read");
    if (oldBackground == null)
      return;
    var textWriter = new StringWriter();
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var serializer = new QXmlSerializer(typeof(DMW.DocumentBackground), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldBackground);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    var textReader = new StringReader(str);
    var newBackground = (DMW.DocumentBackground?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newBackground, $"Deserialized properties are null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldBackground, newBackground, diffs);
    var t6 = DateTime.Now;
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
  }

}
