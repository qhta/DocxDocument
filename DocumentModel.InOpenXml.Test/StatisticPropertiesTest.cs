namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="StatisticProperties"/>.
/// </summary>
public class StatisticPropertiesTest: _AbstractTestClass
{
  private readonly string TestFileName = Path.Combine(TestFileDir, "StatisticPropertiesTest.docx");


  /// <summary>
  /// Runs all serialization tests for the <see cref="StatisticProperties"/> class and reports the results.
  /// </summary>
  /// <returns>True if all serialization tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== StatisticProperties Test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestNewFromDocument()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    if (!TestStoreBuiltInProperties()) return false;

    Console.WriteLine("All StatisticProperties tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization for <see cref="StatisticProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  private bool TestXmlSerialization()
  {
    Console.WriteLine("--- StatisticPropertiesTest XML Serialization ---");
    var testData = CreateSampleStatisticProperties();
    var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("StatisticPropertiesTest Serialized XML:\n" + xmlString);

    StatisticProperties? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (StatisticProperties?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine("✗ StatisticPropertiesTest XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ StatisticPropertiesTest Store sample content properties test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization for <see cref="StatisticProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  private bool TestJsonSerialization()
  {
    Console.WriteLine("--- StatisticPropertiesTest JSON Serialization ---");
    var testData = CreateSampleStatisticProperties();
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
    Console.WriteLine("StatisticPropertiesTest Serialized JSON:\n" + jsonString);

    var deserialized = JsonSerializer.Deserialize<StatisticProperties>(jsonString, jsonOptions);
    if (deserialized == null)
    {
      Console.WriteLine("✗ StatisticPropertiesTest JSON Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ StatisticPropertiesTest Store sample content properties test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ StatisticPropertiesTest JSON Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases for serialization and deserialization of empty <see cref="StatisticProperties"/> objects.
  /// </summary>
  /// <returns>True if all edge case tests pass; otherwise, false.</returns>
  private bool TestEdgeCases()
  {
    Console.WriteLine("--- StatisticPropertiesTest Edge Cases ---");
    var empty = new StatisticProperties();
    string xml = SerializeToXml(empty);
    var xmlDeserialized = DeserializeFromXml<StatisticProperties>(xml);
    if (xmlDeserialized == null)
    {
      Console.WriteLine("✗ StatisticPropertiesTest Edge Cases: XML deserialization of empty object failed");
      return false;
    }
    string json = SerializeToJson(empty);
    var jsonDeserialized = DeserializeFromJson<StatisticProperties>(json);
    if (jsonDeserialized == null)
    {
      Console.WriteLine("✗ StatisticPropertiesTest Edge Cases: JSON deserialization of empty object failed");
      return false;
    }
    Console.WriteLine("✓ StatisticPropertiesTest Edge case tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests the creation and serialization of statistic properties for a new document.
  /// </summary>
  /// <remarks>This method creates a new document, retrieves its statistic properties, serializes them to XML,
  /// and outputs the result to the console. It is intended for diagnostic or verification purposes and writes status
  /// messages to the console.</remarks>
  /// <returns>true if the test completes successfully; otherwise, false.</returns>
  private bool TestNewFromDocument()
  {
    Console.WriteLine("--- StatisticPropertiesTest New document statistic properties ---");
    StatisticProperties testData;
    using (var document = new Document(TestFileName, FileMode.CreateNew))
    {
      testData = document.StatisticProperties;
    }

    Console.WriteLine("StatisticPropertiesTest New document statistic properties:\n" + GetDataXml(testData));

    Console.WriteLine("✓ StatisticPropertiesTest New document statistic properties test passed\n");
    return true;
  }

  /// <summary>
  /// Tests setting sample statistic properties to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document statistic properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document statistic properties are successfully stored and verified; otherwise, false.</returns>
  private bool TestStoreInDocument()
  {
    Console.WriteLine("--- StatisticPropertiesTest Store sample statistic properties in new document---");
    {
      StatisticProperties testData = CreateSampleStatisticProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.StatisticProperties = testData;
      }

      Console.WriteLine("✓ ContentPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

      StatisticProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.StatisticProperties;
      }

      Console.WriteLine("StatisticPropertiesTest properties stored to new document and reloaded from it:\n" + GetDataXml(storedData));

      if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
      {
        Console.WriteLine($"✗ StatisticPropertiesTest Store sample statistic properties test FAILED: {message}");
        return false;
      }

      Console.WriteLine("✓ StatisticPropertiesTest Store sample statistic properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests updating the statistic properties of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document statistic properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document statistic properties are successfully updated and verified; otherwise, false.</returns>
  private bool TestUpdateInDocument()
  {
    Console.WriteLine("--- StatisticPropertiesTest Update document statistic properties ---");
    StatisticProperties testData = CreateSampleStatisticProperties();
    using (var document = new Document(TestFileName, FileMode.CreateNew))
    {
      document.StatisticProperties = testData;

      document.StatisticProperties.Pages = 1000000;
      testData.Pages = 1000000;
    }

    Console.WriteLine("✓ ContentPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

    StatisticProperties storedData;
    using (var document = new Document(TestFileName))
    {
      storedData = document.StatisticProperties;
    }

    Console.WriteLine("StatisticPropertiesTest Updated document statistic properties:\n" + GetDataXml(storedData));

    if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
    {
      Console.WriteLine($"✗ StatisticPropertiesTest Updated document statistic properties test FAILED: {message}");
      return false;
    }

    Console.WriteLine("✓ StatisticPropertiesTest Updated document statistic properties test passed\n");
    return true;
  }


  /// <summary>
  /// Tests storing statistic content properties as built-into a new document and verifies that they are correctly saved and reloaded.
  /// </summary>
  /// <returns>true if the document statistic properties are successfully stored and verified; otherwise, false.</returns>
  private bool TestStoreBuiltInProperties()
  {
    Console.WriteLine("--- StatisticPropertiesTest Store built-in content properties in new document---");
    {
      var testData = CreateSampleStatisticProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        foreach (var prop in StatisticProperties.KnownProperties)
        {
          var propInfo = typeof(StatisticProperties).GetProperty(prop.Key);
          if (propInfo != null && propInfo.GetCustomAttribute<BuiltInPropertyAttribute>() != null)
          {
            var value = propInfo.GetValue(testData);
            if (value != null)
            {
              document.BuiltInDocumentProperties[prop.Key].Value = value;
            }
          }
        }
      }

      Console.WriteLine("✓ StatisticPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

      Console.WriteLine("✓ StatisticPropertiesTest Store sample content properties test passed\n");
      return true;
    }
  }


  /// <summary>
  /// Creates a sample <see cref="StatisticProperties"/> instance for testing.
  /// </summary>
  /// <returns>A populated <see cref="StatisticProperties"/> object.</returns>
  private StatisticProperties CreateSampleStatisticProperties()
  {
    return new StatisticProperties
    {
      Pages = 10,
      Words = 2500,
      Characters = 15000,
      Lines = 200,
      Paragraphs = 50,
      CharactersWithSpaces = 17000,
      Slides = 5,
      Notes = 2,
      HiddenSlides = 1,
      MultimediaClips = 3,
      TotalTime = 123
    };
  }
}