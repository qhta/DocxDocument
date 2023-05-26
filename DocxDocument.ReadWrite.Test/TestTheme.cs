using DocumentModel.OpenXml.Drawings;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document theme part.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestTheme : TestBase
{

  /// <summary>
  /// Tests the normal template theme.
  /// </summary>
  [Test]
  public void TestReadNormalTemplateTheme()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    ReadReadTheme(filename, true);
  }

  /// <summary>
  /// Tests the theme read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadTheme()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      ReadReadTheme(filename);
  }

  /// <summary>
  /// Tests the theme read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void ReadReadTheme(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.Theme);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Theme, "No document Theme read");
    var modelTheme = document.Theme;
    var originTheme = reader.WordprocessingDocument.MainDocumentPart?.ThemePart?.Theme;
    if (originTheme != null)
    {
      var diffs = new DiffList();
      if (!ThemeConverter.CompareModelElement(originTheme, modelTheme, diffs, null, null))
      {
        if (showDetails)
        {
          WriteLine("Read theme differences found:");
          foreach (var diff in diffs)
            WriteLine(diff.ToString());
        }
        Assert.Fail(diffs.FirstOrDefault()?.ToString());
      }
    }
  }

  /// <summary>
  /// Tests theme Xml serialization by reading all docx files,
  /// serialize and deserialize theme using string writer.
  /// </summary>
  [Test]
  public void TestReadThemeXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadThemeXmlSerialization(filename);
  }

  /// <summary>
  /// Tests theme Xml serialization by reading the specified docx file,
  /// serialize and deserialize theme using string writer.
  /// </summary>
  public void TestReadThemeXmlSerialization(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine(filename);

    var reader = new DocxReader(filename);
    var document = reader.GetDocument(PartsMask.Theme);
    DMD.Theme oldTheme = document.Theme ?? new DMD.Theme();
    Assert.IsNotNull(oldTheme, "No document theme read");
    if (oldTheme == null)
      return;
    var textWriter = new StringWriter();
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var serializer = new QXmlSerializer(typeof(DMD.Theme), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldTheme);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    var textReader = new StringReader(str);
    var newTheme = (DMD.Theme?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newTheme, $"Deserialized theme is null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldTheme, newTheme, diffs);
    var t6 = DateTime.Now;
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
  }

}
