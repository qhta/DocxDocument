using DocumentModel.Wordprocessing;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document comments.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestComments : TestBase
{

  /// <summary>
  /// Tests the normal template comments.
  /// </summary>
  [Test]
  public void TestNormalTemplateComments()
  {
    var filename = Path.Combine(TestPath, "Normal.dotm");
    TestReadComments(filename, true);
  }

  /// <summary>
  /// Tests the comments read from "Comments.docx" file.
  /// </summary>
  [Test]
  public void TestReadDocumentComments()
  {
    var filename = Path.Combine(TestPath, "Comments.docx");
    TestReadComments(filename, true);
  }

  /// <summary>
  /// Tests the comments read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadComments()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadComments(filename);
  }

  /// <summary>
  /// Tests the comments read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadComments(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing read comments of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Comments);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Comments, "No document comments read");
    var modelComments = document.Comments;
    var origComments = reader.WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsPart?.Comments;
    var origCommentsEx = reader.WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsExPart?.CommentsEx;
    var origCommentsIds = reader.WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsIdsPart?.CommentsIds;
    var origCommentsExtensible = reader.WordprocessingDocument.MainDocumentPart?.WordCommentsExtensiblePart?.CommentsExtensible;
    if (origComments==null && origCommentsEx==null && origCommentsIds==null && origCommentsExtensible==null)
      return;
    var diffs = new DiffList();
    var ok = DMXW.CommentsConverter.CompareModelElement(origComments, modelComments?.Comments, diffs, null);
    if (!DMXW.CommentsExConverter.CompareModelElement(origCommentsEx, modelComments?.CommentsEx, diffs, null))
      ok = false;
    if (!DMXW.CommentsIdsConverter.CompareModelElement(origCommentsIds, modelComments?.CommentsIds, diffs, null))
      ok = false;
    if (!DMXW.CommentsExtensibleConverter.CmpCommentsExtensibles(origCommentsExtensible, modelComments?.CommentsExtensible, diffs, null))
      ok = false;
    if (!ok && showDetails)
    {
      WriteLine("Read comments differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }

  /// <summary>
  /// Tests comments Xml serialization by reading files,
  /// serialize and deserialize comments using string writer.
  /// </summary>
  [Test]
  public void TestReadCommentsXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadCommentsXmlSerialization(filename);
  }

  /// <summary>
  /// Tests comments Xml serialization by reading file,
  /// serialize and deserialize comments using string writer.
  /// </summary>
  public void TestReadCommentsXmlSerialization(string filename, bool showDetails = false)
  {
    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing comments serialization of: {filename}");
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Comments);
    var oldComments = document.Comments ?? new();
    Assert.IsNotNull(oldComments, "No document comments read");
    if (oldComments == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMW.Comments), extraTypes.ToArray(),
      new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldComments);
    textWriter.Flush();
    string str = textWriter.ToString();
    if (showDetails)
    {
      WriteLine(str);
      WriteLine();
    }

    var textReader = new StringReader(str);
    var newComments = (DMW.DocComments?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newComments, $"Deserialized comments are null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldComments, newComments, diffs);
    if (!ok && showDetails)
    {
      WriteLine("Read comments differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }


}
