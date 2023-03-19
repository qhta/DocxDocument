using DocxDocument.Reader;

namespace DocxDocument.ReadWrite.Test;

/// <summary>
/// Test class for document sections.
/// </summary>
/// <seealso cref="DocxDocument.ReadWrite.Test.TestBase" />
public class TestSections : TestBase
{

  /// <summary>
  /// Tests sections read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadSections()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadSections(filename);
  }

  /// <summary>
  /// Tests read sections from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadSections(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine(filename);
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Body);
    Assert.IsNotNull(document, "No document read");
    Assert.IsNotNull(document.Body, "No document body read");
    var modelBody = document.Body;
    var modelSections = modelBody?.Sections?.ToArray();
    int modelSectionsCount = modelSections?.Count() ?? 0;
    var origBody = reader.WordprocessingDocument.MainDocumentPart?.Document?.Body;
    var origSectionProperties = origBody?.Descendants<DXW.SectionProperties>().ToArray();
    int origSectionPropertiesCount = origSectionProperties?.Count() ?? 0;
    var diffs = new DiffList();
    var ok = DMX.Int32ValueConverter.CmpValue(origSectionPropertiesCount,modelSectionsCount, diffs, "Sections.Count");
    if (modelSections!=null && origSectionProperties!=null)
    for (int i=0; i<Math.Min(modelSectionsCount, origSectionPropertiesCount); i++)
    {
      var modelSectionsProperties = modelSections[i].Properties;
      var origSectionPropertiesElement = origSectionProperties[i];
      DMXW.SectionPropertiesConverter.CompareModelElement(origSectionPropertiesElement, modelSectionsProperties, diffs, $"SectionProperties[{i}]");
    }
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
  /// Tests sections Xml serialization by reading all docx files in folder specified by test path.,
  /// serialize and deserialize body using string writer.
  /// </summary>
  [Test]
  public void TestReadSectionsXmlSerialization()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadSectionsXmlSerialization(filename);
  }

  /// <summary>
  /// Tests body Xml serialization by reading specifed docx file,
  /// serialize and deserialize body using string writer.
  /// </summary>
  public void TestReadSectionsXmlSerialization(string filename)
  {
    var extraTypes = Assembly.Load("DocumentModel").GetTypes()
      .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

    filename = Path.Combine(TestPath, filename);
    WriteLine($"Testing sections of: {filename}");
    var reader = new DocxReader(filename);
    var document = reader.ReadDocument(Parts.Body);
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
    //WriteLine(str);
    WriteLine("=============SerializationEnd=============");

    var textReader = new StringReader(str);
    var newBody = (DMW.Body?)serializer.Deserialize(textReader);
    Assert.IsNotNull(newBody, $"Deserialized body is null");
    var diffs = new DiffList();
    var ok = DeepComparer.IsEqual(oldBody, newBody, diffs);
    if (!ok)
      foreach (var diff in diffs)
        WriteLine(diff.ToString());
    Assert.That(ok, $"Deserialized {diffs.AssertMessage}");
  }

  ///// <summary>
  ///// Tests sections Json serialization by reading all docx files in folder specified by test path,
  ///// serialize and deserialize body using string writer.
  ///// </summary>
  //[Test]
  //public void TestReadSectionsJsonSerialization()
  //{
  //  foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
  //    TestReadSectionsJsonSerialization(filename);
  //}

  ///// <summary>
  ///// Tests sections Json serialization by reading specifed docx file,
  ///// serialize and deserialize body using string writer.
  ///// </summary>
  //public void TestReadSectionsJsonSerialization(string filename)
  //{
  //  var extraTypes = Assembly.Load("DocumentModel").GetTypes()
  //    .Where(item => item.IsPublic && !item.IsGenericType).ToArray();

  //  filename = Path.Combine(TestPath, filename);
  //  var reader = new DocxReader(filename);
  //  var document = reader.ReadDocument(Parts.Body);
  //  var oldBody = document.Body ?? new();
  //  Assert.IsNotNull(oldBody, "No document body read");
  //  if (oldBody == null)
  //    return;
  //  var textWriter = new StringWriter();
  //  var serializer = JsonSerializer.Create(
  //  new JsonSerializerSettings
  //  {
  //    NullValueHandling = NullValueHandling.Ignore,
  //    Formatting = Formatting.Indented,
  //    TypeNameHandling = TypeNameHandling.All, 
  //    DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate,
  //  });
  //  serializer.Serialize(textWriter, oldBody);
  //  textWriter.Flush();
  //  string str = textWriter.ToString();
  //  WriteLine(str);
  //  WriteLine();

  //  var textReader = new StringReader(str);
  //  var jsonReader = new JsonTextReader(textReader);
  //  var newBody = (DMW.Body?)serializer.Deserialize<DMW.Body>(jsonReader);
  //  Assert.IsNotNull(newBody, $"Deserialized body are null");
  //  var oldBodyCount = oldBody.Count;
  //  var newBodyCount = newBody.Count();
  //  var newBodyArray = newBody.ToArray();
  //  var oldBodyArray = oldBody.ToArray();
  //  for (int i = 0; i < Math.Min(oldBodyCount, newBodyCount); i++)
  //  {
  //    var oldItem = oldBodyArray[i];
  //    var newItem = newBodyArray[i];
  //    newItem.ShouldDeepEqual(oldItem);
  //    //Assert.That(newItem, Is.EqualTo(oldItem), $"Deserialized body element \"{oldItem.GetType().Name}\" is different from original");
  //  }
  //  Assert.That(newBodyCount, Is.EqualTo(oldBodyCount), $"Deserialized Body count is different from original");
  //}

}
