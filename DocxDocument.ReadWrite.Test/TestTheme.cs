using System.Reflection;

using DocumentFormat.OpenXml.Wordprocessing;

using DocumentModel;
using DocumentModel.OpenXml;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.OpenXml.Drawings;

using Qhta.Xml.Serialization;
using System.Xml;

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
  /// Tests the theme read from "DocumentProperties.docx".
  /// </summary>
  [Test]
  public void TestReadDocumentTheme()
  {
    var filename = Path.Combine(TestPath, "DocumentProperties.docx");
    ReadReadTheme(filename, true);
  }

  /// <summary>
  /// Tests the theme read from "CustomProperties.docx".
  /// </summary>
  [Test]
  public void TestCustomTheme()
  {
    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    ReadReadTheme(filename, true);
  }

  /// <summary>
  /// Tests the theme read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestSampleDocsTheme()
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
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Theme);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Theme, "No document Theme read");
    var modelTheme = document.Theme;
    var originTheme = reader.WordprocessingDocument.MainDocumentPart?.ThemePart?.Theme;

    var diffs = new DiffList();
    if (!ThemeConverter.CompareModelElement(originTheme, modelTheme, diffs, null))
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

  /// <summary>
  /// Tests theme Xml serialization by reading "CustomProperties.docx" file,
  /// serialize and deserialize theme using string writer.
  /// </summary>
  [Test]
  public void TestThemeXmlSerialization()
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    var filename = Path.Combine(TestPath, "CustomProperties.docx");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Theme);
    DMDraws.Theme oldTheme = document.Theme ?? new DMDraws.Theme();//TestReadProperties(filename, true);
    Assert.IsNotNull(oldTheme, "No document theme read");
    if (oldTheme == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMDraws.Theme), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldTheme);
    textWriter.Flush();
    string str = textWriter.ToString();
    WriteLine(str);
    WriteLine();

    var textReader = new StringReader(str);
    var newTheme = (DMDraws.Theme?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newTheme, $"Deserialized properties are null");
    newTheme.ShouldDeepEqual(oldTheme);
  }

}
