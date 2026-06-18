namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Numbering.
/// </summary>
public abstract class _AbstractModelTestClass<ModelDataType> : _AbstractTestClass
  where ModelDataType : DM.ModelElement, new()
{
  /// <summary>
  /// Test file name for storing the document during tests.
  /// </summary>
  protected string TestFileName => Path.Combine(TestFileDir, $"{TestName}Test.docx");

  /// <summary>
  /// Runs all tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine($"=== {TestName} test ===\n");
    if (!TestJsonSerialization()) return false;
    if (!TestXmlSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestStoreDataInOpenXmlDocument()) return false;
    if (!TestUpdateDataInOpenXmlDocument()) return false;
    //if (!TestStoreDataInXmlDocument()) return false;
    Console.WriteLine($"All {TestName} tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization of the model collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  protected virtual bool TestXmlSerialization()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    var testData = CreateSampleData();
    var xmlSerializer = XmlSerializationHelper.CreateXmlSerializer(testData, out var namespaces);
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData, namespaces);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine($"{TestName} Serialized XML:\n" + xmlString);

    ModelDataType? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (ModelDataType?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine($"✗ {TestName} XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData<ModelDataType>(typeof(ModelDataType), testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ {TestName} {testMethodName} FAILED: {message}");
      return false;
    }
    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization of the model collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  protected virtual bool TestJsonSerialization()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    var testData = CreateSampleData();
    string jsonString = SerializeToJson(testData);
    Console.WriteLine($"{TestName} Serialized JSON:\n" + jsonString);
    var deserialized = DeserializeFromJson<ModelDataType>(jsonString);
    if (deserialized == null)
    {
      Console.WriteLine($"✗ {TestName} JSON Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ {TestName} {testMethodName} FAILED: {message}");
      return false;
    }
    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases like empty model collection.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  protected virtual bool TestEdgeCases()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    var empty = new ModelDataType();
    string xml = SerializeToXml(empty);
    var xmlDeserialized = DeserializeFromXml<ModelDataType>(xml);
    if (xmlDeserialized == null)
    {
      Console.WriteLine($"✗ {TestName} {testMethodName}: XML deserialization of empty object failed");
      return false;
    }
    string json = SerializeToJson(empty);
    var jsonDeserialized = DeserializeFromJson<ModelDataType>(json);
    if (jsonDeserialized == null)
    {
      Console.WriteLine($"✗ {TestName} {testMethodName}: JSON deserialization of empty object failed");
      return false;
    }
    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }


  /// <summary>
  /// Tests setting sample model collection to a new OpenXml document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that OpenXml document model collection can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the OpenXml document model collection is successfully stored and verified; otherwise, false.</returns>
  protected virtual bool TestStoreDataInXmlDocument()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    ModelDataType testData = CreateSampleData();
    string xmlString;
    using (var document = Document.Open(TestFileName, FileMode.CreateNew))
    {
      SetDataToDocument(document, testData);
      xmlString = document.GetModelXml();
    }


    Console.WriteLine($"{TestName} {testMethodName} Xml data is:\n" + xmlString);
    //    Debug.WriteLine($"XmlLength: {xmlString.Length}");
    if (xmlString.Length < 500)
    {
      Console.WriteLine($"✗ {TestName} {testMethodName} failed: XML data is too short\n");
      return false;
    }
    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests setting sample model collection to a new OpenXml document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that OpenXml document model collection can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the OpenXml document model collection is successfully stored and verified; otherwise, false.</returns>
  protected virtual bool TestStoreDataInOpenXmlDocument()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    ModelDataType testData = CreateSampleData();
    using (var document = Document.Open(TestFileName, FileMode.CreateNew))
    {
      SetDataToDocument(document, testData);
    }

    using (var document = Document.Open(TestFileName))
    {
      var openXml = GetOpenXmlFromDocument(document);
      if (openXml != null)
      {
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);
        var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
        if (!validationResult.IsValid)
        {
          Console.WriteLine($"✗ {TestName} {testMethodName} OpenXml schema validation FAILED - issues found:");
          foreach (var msg in validationResult.Messages) Console.WriteLine($" {msg}");
          return false;
        }
      }
    }

    ModelDataType storedData;
    using (var document = Document.Open(TestFileName))
    {
      storedData = GetDataFromDocument(document) ?? throw new InvalidOperationException($"{typeof(ModelDataType).Name} not found.");
    }

    var xmlSerializer = CreateXmlSerializer(typeof(ModelDataType), out var namespaces);
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData, namespaces);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine($"{TestName} {testMethodName} reloaded data is:\n" + xmlString);

    if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
    {
      Console.WriteLine($"✗ {TestName} {testMethodName} FAILED: {message}");
      return false;
    }

    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Tests updating the sample collection in a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Numbering can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Numbering are successfully updated and verified; otherwise, false.</returns>
  protected virtual bool TestUpdateDataInOpenXmlDocument()
  {
    var testMethodName = GetInvokingMethodName();
    Console.WriteLine($"--- {TestName} {testMethodName} ---");
    ModelDataType testData = CreateSampleData();
    ModelDataType updatedData;
    using (var document = Document.Open(TestFileName, FileMode.CreateNew))
    {
      var storedData = SetDataToDocument(document, testData);
      updatedData = UpdateDataInDocument(document, storedData);
      //if (TestHelper.CompareTestData(testData, updatedData, "storedData", "updatedData", out _))
      //{
      //  Console.WriteLine($"✗ {TestName} {testMethodName} failed: updated data was not changed.");
      //  return false;
      //}
    }
    using (var document = Document.Open(TestFileName))
    {
      var openXml = GetOpenXmlFromDocument(document);
      if (openXml != null)
      {
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);
        var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
        if (!validationResult.IsValid)
        {
          Console.WriteLine($"✗ {TestName} {testMethodName} OpenXml schema validation FAILED - issues found:");
          foreach (var msg in validationResult.Messages) Console.WriteLine($" {msg}");
          return false;
        }
      }
    }

    ModelDataType restoredData;
    using (var document = Document.Open(TestFileName))
    {
      restoredData = GetDataFromDocument(document) ?? throw new InvalidOperationException($"{typeof(ModelDataType).Name} not found."); ;
    }

    var xmlSerializer = CreateXmlSerializer(typeof(ModelDataType), out var namespaces);
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, restoredData, namespaces);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine($"{TestName} {testMethodName} updated data is:\n" + xmlString);

    if (!TestHelper.CompareTestData(updatedData, restoredData, "storedData", "updatedData", out var message))
    {
      Console.WriteLine($"✗ {TestName} {testMethodName} FAILED: {message}");
      return false;
    }

    Console.WriteLine($"✓ {TestName} {testMethodName} passed\n");
    return true;
  }

  /// <summary>
  /// Creates a sample model collection object with various items.
  /// </summary>
  /// <returns>A populated sample model collection object.</returns>
  protected virtual ModelDataType CreateSampleData()
  {
    var result = new ModelDataType();
    TestHelper.PopulateTestData(result);
    return result;
  }

  /// <summary>
  /// Gets the model collection data from the specified document.
  /// </summary>
  /// <param name="document">The document from which the data is to be retrieved.</param>
  /// <returns>The model data from the document.</returns>
  protected virtual ModelDataType GetDataFromDocument(Document document)
  {
    var property = typeof(Document).GetProperties().FirstOrDefault(p => p.PropertyType == typeof(ModelDataType));
    if (property == null) throw new InvalidOperationException($"Type {typeof(ModelDataType).Name} not found.");
    var result = (ModelDataType)property.GetValue(document)!;
    if (result is IDirectAccessElement directAccessElement && result is ILoadable loadableResult)
      if (directAccessElement.HasDirectAccess)
        loadableResult.LoadData();
    return result;
  }

  /// <summary>
  /// Sets the specified document property for the given model collection element.
  /// </summary>
  /// <param name="document">The document in which the data is to be set.</param>
  /// <param name="data">The model data for which the document property is to be set.</param>
  protected virtual ModelDataType SetDataToDocument(Document document, ModelDataType data)
  {
    var property = typeof(Document).GetProperties().FirstOrDefault(p => p.PropertyType == typeof(ModelDataType));
    if (property == null) throw new InvalidOperationException($"Type {typeof(ModelDataType).Name} not found.");
    property.SetValue(document, data);
    return (ModelDataType)property.GetValue(document)!;
  }

  /// <summary>
  /// Updates the specified document for the given model data.
  /// </summary>
  /// <param name="document">The document in which the data is to be set.</param>
  /// <param name="data">The model data for which the document property is to be set.</param>
  protected abstract ModelDataType UpdateDataInDocument(Document document, ModelDataType data);

  /// <summary>
  /// Gets the OpenXml representation of the model collection from the specified document.
  /// </summary>
  /// <param name="document">The document from which to retrieve the OpenXml representation.</param>
  /// <returns>The OpenXml representation of the model collection.</returns>
  protected abstract string? GetOpenXmlFromDocument(Document document);

}