using System.Data;
using System.Xml;

using DocxDocument.Reader;
using Qhta.Xml.Serialization;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document paragraphs.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestBody : TestBase
{

  /// <summary>
  /// Tests paragraphs read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadDocumentBody()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadDocumentBody(filename);
  }

  /// <summary>
  /// Tests body read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadDocumentBody(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Body);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Body, "No document body read");
    var modelBody = document.Body;
    int modelBodyCount = modelBody?.Count() ?? 0;
    var origBody = reader.WordprocessingDocument.MainDocumentPart?.Document?.Body;
    int origBodyCount = origBody?.Elements().Count() ?? 0;
    var diffs = new DiffList();
    var ok = DMXW.BodyConverter.CompareModelElement(origBody, modelBody, diffs, null);
    if (!ok && showDetails)
    {
      WriteLine("Read body differences found:");
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    }
    if (!ok)
      Assert.Fail(diffs.FirstOrDefault()?.ToString());
  }

  /// <summary>
  /// Tests body Xml serialization by reading all docx files in folder specified by test path.,
  /// serialize and deserialize body using string writer.
  /// </summary>
  [Test]
  public void TestReadBodyXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadBodyXmlSerialization(filename);
  }

  /// <summary>
  /// Tests body Xml serialization by reading specifed docx file,
  /// serialize and deserialize body using string writer.
  /// </summary>
  public void TestReadBodyXmlSerialization(string filename)
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing body of: {filename}");
    var reader = new DocxReader(filename);
    var t0 = DateTime.Now;
    var document = reader.ReadDocument(Parts.Body);
    var t1 = DateTime.Now;
    WriteLine($"ReadDocument time = {(t1-t0).TotalSeconds} s");
    var oldBody = document.Body ?? new();
    Assert.IsNotNull(oldBody, "No document body read");
    if (oldBody == null)
      return;
    var textWriter = new StringWriter();
    var serializer = new QXmlSerializer(typeof(DMW.Body), extraTypes.ToArray(),
          new SerializationOptions { AcceptAllProperties = true });
    serializer.Serialize(textWriter, oldBody);
    textWriter.Flush();
    string str = textWriter.ToString();
    var t2 = DateTime.Now;
    WriteLine(str);
    WriteLine();
    WriteLine($"Serialization time = {(t2-t1).TotalSeconds} s");

    var t3 = DateTime.Now;
    var textReader = new StringReader(str);
    var newBody = (DMW.Body?)serializer.Deserialize(textReader);
    var t4 = DateTime.Now;
    WriteLine($"Deserialization time = {(t4-t3).TotalSeconds} s");

    Assert.IsNotNull(newBody, $"Deserialized body is null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldBody, newBody, diffs);
    var t5 = DateTime.Now;
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
    WriteLine($"DeepCompare time = {(t5-t4).TotalSeconds}");
    WriteLine($"DeepCompare KnownProperties.Count = {DeepComparer.KnownProperties.Count}");
    WriteLine($"DeepCompare KnownCompareFunctions.Count = {DeepComparer.KnownCompareFunctions.Count}");
    WriteLine($"DeepCompare ComparedProperties.Count = {DeepComparer.ComparedProperties.Count}");
  }

  /// <summary>
  /// Tests body Json serialization by reading all docx files in folder specified by test path.,
  /// serialize and deserialize body using string writer.
  /// </summary>
  [Test]
  public void TestReadBodyJsonSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadBodyJsonSerialization(filename);
  }

  /// <summary>
  /// Tests body Json serialization by reading specifed docx file,
  /// serialize and deserialize body using string writer.
  /// </summary>
  public void TestReadBodyJsonSerialization(string filename)
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    filename = Path.Combine(TestPath, filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Body);
    var oldBody = document.Body ?? new();
    Assert.IsNotNull(oldBody, "No document body read");
    if (oldBody == null)
      return;
#if NET7_0_OR_GREATER
    var str = JsonSerializer.Serialize(oldBody, oldBody.GetType(),
      new JsonSerializerOptions
      {
      });
#else
    var textWriter = new StringWriter();
    var serializer = JsonSerializer.Create(
    new JsonSerializerSettings
    {
      NullValueHandling = NullValueHandling.Ignore,
      Formatting = Newtonsoft.Json.Formatting.Indented,
      TypeNameHandling = TypeNameHandling.All,
      DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
    });
    serializer.Serialize(textWriter, oldBody);
    textWriter.Flush();
    string str = textWriter.ToString();
#endif
    WriteLine(str);
    WriteLine();

#if NET7_0_OR_GREATER
    var newBody = (DMW.Body?)JsonSerializer.Deserialize<DMW.Body>(str);
#else
    var textReader = new StringReader(str);
    var jsonReader = new JsonTextReader(textReader);
    var newBody = (DMW.Body?)serializer.Deserialize<DMW.Body>(jsonReader);
#endif
    Assert.IsNotNull(newBody, $"Deserialized body are null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldBody, newBody, diffs);
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
  }

}
