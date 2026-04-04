namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="StatisticProperties"/>.
/// </summary>
public class StatisticPropertiesTest: AbstractTestClass
{
  /// <summary>
  /// Runs all serialization tests for the <see cref="StatisticProperties"/> class and reports the results.
  /// </summary>
  /// <returns>True if all serialization tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== StatisticProperties Test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestNewFromDocument()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    Console.WriteLine("All StatisticProperties tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization for <see cref="StatisticProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  static bool TestXmlSerialization()
  {
    Console.WriteLine("--- XML Serialization ---");
    var testData = CreateSampleStatisticProperties();
    {
      var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      StatisticProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (StatisticProperties?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ Store sample content properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests JSON serialization and deserialization for <see cref="StatisticProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  static bool TestJsonSerialization()
  {
    Console.WriteLine("--- JSON Serialization ---");
    var testData = CreateSampleStatisticProperties();
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<StatisticProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ Store sample content properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }
      Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests edge cases for serialization and deserialization of empty <see cref="StatisticProperties"/> objects.
  /// </summary>
  /// <returns>True if all edge case tests pass; otherwise, false.</returns>
  static bool TestEdgeCases()
  {
    Console.WriteLine("--- Edge Cases ---");
    {
      var empty = new StatisticProperties();
      string xml = SerializeToXml(empty);
      var xmlDeserialized = DeserializeFromXml(xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine("✗ Edge Cases: XML deserialization of empty object failed");
        return false;
      }
      string json = SerializeToJson(empty);
      var jsonDeserialized = DeserializeFromJson(json);
      if (jsonDeserialized == null)
      {
        Console.WriteLine("✗ Edge Cases: JSON deserialization of empty object failed");
        return false;
      }
      Console.WriteLine("✓ Edge case tests passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests the creation and serialization of statistic properties for a new document.
  /// </summary>
  /// <remarks>This method creates a new document, retrieves its statistic properties, serializes them to XML,
  /// and outputs the result to the console. It is intended for diagnostic or verification purposes and writes status
  /// messages to the console.</remarks>
  /// <returns>true if the test completes successfully; otherwise, false.</returns>
  static bool TestNewFromDocument()
  {
    Console.WriteLine("--- New document statistic properties ---");
    {
      StatisticProperties testData;
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        testData = document.StatisticProperties;
      }
      var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("New document statistic properties:\n" + xmlString);

      Console.WriteLine("✓ New document statistic properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests setting sample statistic properties to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document statistic properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document statistic properties are successfully stored and verified; otherwise, false.</returns>
  static bool TestStoreInDocument()
  {
    Console.WriteLine("--- Store sample statistic properties in new document---");
    {
      StatisticProperties testData = CreateSampleStatisticProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.StatisticProperties = testData;
      }

      StatisticProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.StatisticProperties;
      }

      var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("statistic properties stored to new document and reloaded from it:\n" + xmlString);

      if (!TestHelper.CompareTestData(testData, storedData, out var propName))
      {
        Console.WriteLine($"✗ Store sample statistic properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓ Store sample statistic properties test passed\n");
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
  static bool TestUpdateInDocument()
  {
    Console.WriteLine("--- Update document statistic properties ---");
    {
      StatisticProperties testData = CreateSampleStatisticProperties();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.StatisticProperties = testData;

        document.StatisticProperties.Pages = 1000000;
        testData.Pages = 1000000;
      }

      StatisticProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.StatisticProperties;
      }

      var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Updated document statistic properties:\n" + xmlString);

      if (!TestHelper.CompareTestData(testData, storedData, out var propName))
      {
        Console.WriteLine($"✗ Updated document statistic properties test FAILED - data mismatch in property '{propName}'");
        return false;
      }

      Console.WriteLine("✓ Updated document statistic properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Creates a sample <see cref="StatisticProperties"/> instance for testing.
  /// </summary>
  /// <returns>A populated <see cref="StatisticProperties"/> object.</returns>
  static StatisticProperties CreateSampleStatisticProperties()
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

  /// <summary>
  /// Serializes a <see cref="StatisticProperties"/> instance to XML.
  /// </summary>
  /// <param name="props">The <see cref="StatisticProperties"/> instance to serialize.</param>
  /// <returns>XML string representation.</returns>
  static string SerializeToXml(StatisticProperties props)
  {
    var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, props);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes a <see cref="StatisticProperties"/> instance from XML.
  /// </summary>
  /// <param name="xml">The XML string to deserialize.</param>
  /// <returns>The deserialized <see cref="StatisticProperties"/> instance.</returns>
  static StatisticProperties? DeserializeFromXml(string xml)
  {
    var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
    using (var stringReader = new StringReader(xml))
    {
      return (StatisticProperties?)xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Serializes a <see cref="StatisticProperties"/> instance to JSON.
  /// </summary>
  /// <param name="props">The <see cref="StatisticProperties"/> instance to serialize.</param>
  /// <returns>JSON string representation.</returns>
  static string SerializeToJson(StatisticProperties props)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Serialize(props, jsonOptions);
  }

  /// <summary>
  /// Deserializes a <see cref="StatisticProperties"/> instance from JSON.
  /// </summary>
  /// <param name="json">The JSON string to deserialize.</param>
  /// <returns>The deserialized <see cref="StatisticProperties"/> instance.</returns>
  static StatisticProperties? DeserializeFromJson(string json)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Deserialize<StatisticProperties>(json, jsonOptions);
  }
}