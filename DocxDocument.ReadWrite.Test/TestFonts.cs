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
  public void TestReadFonts()
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
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing read fonts of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.FontTable);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Fonts, "No document fonts read");
    var modelFonts = document.Fonts;
    var origFonts = reader.WordprocessingDocument.MainDocumentPart?.FontTablePart?.Fonts;
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
  /// Tests embed fonts read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadEmbedFonts()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadEmbedFonts(filename);
  }

  /// <summary>
  /// Tests embed fonts read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadEmbedFonts(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing read fonts of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.FontTable | PartsMask.EmbeddedFonts);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Fonts, "No document fonts read");
    var modelFonts = document.EmbeddedFonts;
    var origFonts = reader.WordprocessingDocument.MainDocumentPart?.FontTablePart?.Parts;
    var diffs = new DiffList();
    var ok = DMX.Int32ValueConverter.CmpValue(origFonts?.Count() ?? 0, modelFonts?.Count() ?? 0, diffs, null);
    if (!ok && showDetails)
    {
      WriteLine("Read fonts differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
    if (showDetails)
    {
      foreach (var font in document.Fonts)
      {
        WriteLine($"Font: {font.Name}");
        if (font.EmbedRegularFont != null)
          WriteLine($"  EmbedRegularFont id={font.EmbedRegularFont.Id} size={font.EmbedRegularFont.GetEmbedFont()?.Length}");
      }
    }
  }

  /// <summary>
  /// Tests fonts Xml serialization by reading files,
  /// serialize and deserialize fonts using string writer.
  /// </summary>
  [Test]
  public void TestReadFontsXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadFontsXmlSerialization(filename);
  }

  /// <summary>
  /// Tests fonts Xml serialization by reading file,
  /// serialize and deserialize fonts using string writer.
  /// </summary>
  public void TestReadFontsXmlSerialization(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing fonts serialization of: {filename}");
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.FontTable);
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
    if (showDetails)
    {
      WriteLine(str);
      WriteLine();
    }

    var textReader = new StringReader(str);
    var newFonts = (DMW.Fonts?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newFonts, $"Deserialized fonts are null");
    var newFontsArray = newFonts.ToArray();
    var oldFontsArray = oldFonts.ToArray();
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldFontsArray, newFontsArray, diffs);
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
  /// Tests embed fonts Xml serialization by reading files,
  /// serialize and deserialize fonts using string writer.
  /// </summary>
  [Test]
  public void TestReadEmbedFontsXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadEmbedFontsXmlSerialization(filename);
  }

  /// <summary>
  /// Tests fonts Xml serialization by reading file,
  /// serialize and deserialize fonts using string writer.
  /// </summary>
  public void TestReadEmbedFontsXmlSerialization(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing embedded fonts serialization of: {filename}");
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.EmbeddedFonts);
    var oldFonts = document.EmbeddedFonts ?? new();
    if (oldFonts == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMW.EmbeddedFonts), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldFonts);
    textWriter.Flush();
    string str = textWriter.ToString();
    if (showDetails)
    {
      WriteLine(str);
      WriteLine();
    }

    var textReader = new StringReader(str);
    var newFonts = (DMW.EmbedFontData?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newFonts, $"Deserialized fonts are null");
    var newFontsArray = newFonts.ToArray();
    var oldFontsArray = oldFonts.ToArray();
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldFontsArray, newFontsArray, diffs);
    if (!ok && showDetails)
    {
      WriteLine("Read fonts differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }

}
