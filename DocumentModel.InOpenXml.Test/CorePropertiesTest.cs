using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.CoreProperties.
/// </summary>
public class CorePropertiesTest: _AbstractTestClass
{
  private static readonly string TestFileName = Path.Combine(TestFileDir, "CorePropertiesTest.docx");

  /// <summary>
  /// Runs all CoreProperties serialization tests and reports the results.
  /// </summary>
  /// <returns>true if all CoreProperties serialization tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== CorePropertiesTest ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestNewFromDocument()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    if (!TestStoreBuiltInProperties()) return false;


    Console.WriteLine("All CorePropertiesTest passed.\n");
    return true;
  }

  /// <summary>
  /// Tests the XML serialization and deserialization process for the CoreProperties type, verifying that data is
  /// preserved accurately.
  /// </summary>
  /// <remarks>This method writes diagnostic messages to the console indicating the progress and result of
  /// the test. It is intended for use in validation or debugging scenarios to ensure that XML serialization is
  /// functioning as expected.</remarks>
  /// <returns>true if the CoreProperties object is correctly serialized and deserialized without data loss; otherwise, false.</returns>
  static bool TestXmlSerialization()
  {
    Console.WriteLine("--- CorePropertiesTest XML Serialization ---");
    var testData = CreateSampleCoreProperties();
    var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("CorePropertiesTest Serialized XML:\n" + xmlString);

    CoreProperties? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (CoreProperties?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine("✗ CorePropertiesTest XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
    {
      Console.WriteLine(
        $"✗ CorePropertiesTest XML Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
      return false;
    }
    Console.WriteLine("✓ CorePropertiesTest XML Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests the JSON serialization and deserialization process for the CoreProperties object, verifying that data
  /// integrity is maintained.
  /// </summary>
  /// <remarks>This method writes diagnostic output to the console, including details of the serialized JSON
  /// and any errors encountered during the test. It is intended for use in test scenarios to validate the correctness
  /// of JSON serialization logic.</remarks>
  /// <returns>true if the CoreProperties object is correctly serialized and deserialized without data loss or mismatch;
  /// otherwise, false.</returns>
  static bool TestJsonSerialization()
  {
    Console.WriteLine("--- CorePropertiesTest JSON Serialization ---");
    var testData = CreateSampleCoreProperties();
    {
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<CoreProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ CorePropertiesTest JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
      {
        Console.WriteLine(
          $"✗ CorePropertiesTest JSON Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
        return false;
      }
      Console.WriteLine("✓ CorePropertiesTest JSON Serialization/Deserialization test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests serialization and deserialization edge cases for empty objects using both XML and JSON formats.
  /// </summary>
  /// <remarks>This method writes diagnostic messages to the console indicating the success or failure of
  /// each edge case test. It is intended for use in verifying that serialization and deserialization logic correctly
  /// handles empty objects without errors.</remarks>
  /// <returns>true if all edge case tests pass; otherwise, false.</returns>
  static bool TestEdgeCases()
  {
    Console.WriteLine("--- CorePropertiesTest Edge Cases ---");
    {
      var empty = new CoreProperties();
      string xml = SerializeToXml(empty);
      var xmlDeserialized = DeserializeFromXml<CoreProperties>(xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine("✗ CorePropertiesTest Edge Cases: XML deserialization of empty object failed");
        return false;
      }
      string json = SerializeToJson(empty);
      var jsonDeserialized = DeserializeFromJson<CoreProperties>(json);
      if (jsonDeserialized == null)
      {
        Console.WriteLine("✗ CorePropertiesTest Edge Cases: JSON deserialization of empty object failed");
        return false;
      }
      Console.WriteLine("✓ CorePropertiesTest Edge Cases tests passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests the creation and serialization of properties for a new document.
  /// </summary>
  /// <remarks>This method creates a new document, retrieves its properties, serializes them to XML,
  /// and outputs the result to the console. It is intended for diagnostic or verification purposes and writes status
  /// messages to the console.</remarks>
  /// <returns>true if the test completes successfully; otherwise, false.</returns>
  static bool TestNewFromDocument()
  {
    Console.WriteLine("--- CorePropertiesTest New document properties ---");
    {
      CoreProperties testData;
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        testData = document.CoreProperties;
      }
      var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("CorePropertiesTest New document properties:\n" + xmlString);

      Console.WriteLine("✓ CorePropertiesTest New document properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests setting sample properties to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document properties are successfully stored and verified; otherwise, false.</returns>
  static bool TestStoreInDocument()
  {
    Console.WriteLine("--- CorePropertiesTest Store sample properties in new document---");
    {
      CoreProperties testData = CreateSampleCoreProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.CoreProperties = testData;
      }

      Console.WriteLine("✓ CorePropertiesTest Test: CoreFileProperties stored in document:\n" + CorePropertiesPartXml(TestFileName));

      CoreProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.CoreProperties;
      }

      Console.WriteLine("CorePropertiesTest: Properties stored to new document and reloaded from it:\n" + GetDataXml(storedData));

      if (!TestHelper.CompareTestData(testData, storedData, out var propName))
      {
        Console.WriteLine($"✗ CorePropertiesTest Store sample properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓ CorePropertiesTest Store sample properties test passed\n");
      return true;
    }
  }


  /// <summary>
  /// Tests updating the properties of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document properties are successfully updated and verified; otherwise, false.</returns>
  static bool TestUpdateInDocument()
  {
    Console.WriteLine("--- CorePropertiesTest Update document properties ---");
    {
      CoreProperties testData = CreateSampleCoreProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.CoreProperties = testData;
        document.CoreProperties.Title = "Updated Title";
      }

      Console.WriteLine("✓ CorePropertiesTest Test: CoreFileProperties stored in document:\n" + CorePropertiesPartXml(TestFileName));

      CoreProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.CoreProperties;
      }

      Console.WriteLine("CorePropertiesTest: Updated document properties:\n" + GetDataXml(storedData));

      if (storedData.Title != "Updated Title")
      {
        var propName = "Title";
        Console.WriteLine($"✗ CorePropertiesTest Updated document properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓CorePropertiesTest  Updated document properties test passed\n");
      return true;
    }
  }


  /// <summary>
  /// Tests setting sample Built-in properties to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document properties are successfully stored and verified; otherwise, false.</returns>
  static bool TestStoreBuiltInProperties()
  {
    Console.WriteLine("--- CorePropertiesTest store built-in properties in new document---");
    {
      CoreProperties testData = CreateSampleCoreProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        foreach (var prop in CoreProperties.KnownProperties)
        {
          var propInfo = typeof(CoreProperties).GetProperty(prop.Key);
          if (propInfo != null)
          {
            var value = propInfo.GetValue(testData);
            if (value != null)
            {
              document.BuiltInDocumentProperties[prop.Key].Value = value;
            }
          }
        }
        document.BuiltInDocumentProperties["Title"].Value += " Updated";
      }
      testData.Title += " Updated";

      Console.WriteLine("✓ BuiltInProperties Test: CoreFileProperties stored in document:\n" + CorePropertiesPartXml(TestFileName));

      CoreProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.CoreProperties;
      }

      var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("CorePropertiesTest store built-in properties stored to new document and reloaded from it:\n" + xmlString);

      if (!TestHelper.CompareTestData(testData, storedData, out var propName))
      {
        Console.WriteLine($"✗ CorePropertiesTest store built-in properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓ CorePropertiesTest store built-in properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Creates a new instance of the CoreProperties class populated with sample metadata values for testing or
  /// demonstration purposes.
  /// </summary>
  /// <remarks>The returned CoreProperties instance contains preset values suitable for use in serialization
  /// tests or as a template for document property configuration. The associated document is created in a temporary
  /// file and disposed after the properties are initialized.</remarks>
  /// <returns>A CoreProperties object initialized with example document metadata such as title, subject, creator, and other
  /// properties.</returns>
  static CoreProperties CreateSampleCoreProperties()
  {
    var props = new CoreProperties()
    {
      Title = "Sample Title",
      Subject = "Sample Subject",
      Creator = "Test Creator",
      Keywords = "test,serialization,core",
      Description = "A test description for serialization.",
      LastModifiedBy = "TestUser",
      Revision = 5,
      LastPrinted = new DateTime(2024, 1, 1, 12, 0, 0),
      Created = new DateTime(2023, 12, 31, 23, 59, 59),
      Modified = new DateTime(2024, 1, 2, 8, 30, 0),
      Category = "TestCategory",
      Identifier = "ID-12345",
      ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
      Language = "en-US",
      Version = "1.0",
      ContentStatus = "Draft"
    };
    return props;
  }




}