namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Numbering.
/// </summary>
public class NumberingInstancesTest : _AbstractTestClass
{
  private readonly string TestFileName = Path.Combine(TestFileDir, "NumberingInstancesTest.docx");

  /// <summary>
  /// Runs all Numbering serialization tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== NumberingInstances test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    Console.WriteLine("All NumberingInstances tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization of Numbering.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestXmlSerialization()
  {
    Console.WriteLine("--- NumberingInstances XML Serialization ---");
    var testData = CreateSampleNumbering();
    var xmlSerializer = new XmlSerializer(typeof(Numbering));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("NumberingInstances Serialized XML:\n" + xmlString);

    Numbering? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (Numbering?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine("✗ NumberingInstances XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ NumberingInstances XML Serialization/Deserialization test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ NumberingInstances XML Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization of Numbering.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestJsonSerialization()
  {
    Console.WriteLine("--- NumberingInstances JSON Serialization ---");
    var testData = CreateSampleNumbering();
    var jsonOptions = JsonConfig.Options;
    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
    Console.WriteLine("Serialized JSON:\n" + jsonString);

    var deserialized = JsonSerializer.Deserialize<Numbering>(jsonString, jsonOptions);
    if (deserialized == null)
    {
      Console.WriteLine("✗ NumberingInstances JSON Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ NumberingInstances JSON Serialization/Deserialization test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ NumberingInstances JSON Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases like empty Numbering object.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestEdgeCases()
  {
    Console.WriteLine("--- NumberingInstances Edge Cases ---");
    var empty = new Numbering();
    string xml = SerializeToXml(empty);
    var xmlDeserialized = DeserializeFromXml(xml);
    if (xmlDeserialized == null)
    {
      Console.WriteLine("✗ NumberingInstances Edge Cases: XML deserialization of empty object failed");
      return false;
    }
    string json = SerializeToJson(empty);
    var jsonDeserialized = DeserializeFromJson(json);
    if (jsonDeserialized == null)
    {
      Console.WriteLine("✗ NumberingInstances Edge Cases: JSON deserialization of empty object failed");
      return false;
    }
    Console.WriteLine("✓ NumberingInstances Edge case tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests setting sample Numbering to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Numbering can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Numbering are successfully stored and verified; otherwise, false.</returns>
  private bool TestStoreInDocument()
  {
    Console.WriteLine("--- Store sample NumberingInstances in new document---");
    Numbering testData = CreateSampleNumbering();
    using (var document = Document.Open(TestFileName, FileMode.CreateNew))
    {
      document.Numbering = testData;
    }

    using (var document = Document.Open(TestFileName))
    {
      var openXml = document.WordprocessingDocument!.MainDocumentPart!.NumberingDefinitionsPart!.Numbering!.OuterXml;
      var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
      Console.WriteLine(formattedOpenXml);
      var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
      if (!validationResult.IsValid)
      {
        Console.WriteLine("✗ NumberingInstances OpenXml schema validation FAILED - issues found:");
        foreach (var msg in validationResult.Messages)
        {
          Console.WriteLine($" {msg}");
        }
        return false;
      }
    }

    Numbering storedData;
    using (var document = Document.Open(TestFileName))
    {
      storedData = document.Numbering ?? throw new InvalidOperationException("Numbering not found.");
    }

    var xmlSerializer = new XmlSerializer(typeof(Numbering));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("NumberingInstances stored to new document and reloaded from it:\n" + xmlString);

    if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
    {
      Console.WriteLine($"✗ Store sample NumberingInstances test FAILED: {message}");
      return false;
    }

    Console.WriteLine("✓ Store sample abstract numbering test passed\n");
    return true;
  }

  /// <summary>
  /// Tests updating the Numbering of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Numbering can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Numbering are successfully updated and verified; otherwise, false.</returns>
  private bool TestUpdateInDocument()
  {
    Console.WriteLine("--- Update document NumberingInstances ---");
    Numbering testData = CreateSampleNumbering();
    var initialCount = testData.NumberingInstances.Count;
    using (var document = Document.Open(TestFileName, FileMode.CreateNew))
    {
      document.Numbering = testData;
      document.Numbering.NumberingInstances.Add(new NumberingInstance()
      {
        AbstractNumId = 1,
        NumberID = 4,
      });
    }
    using (var document = Document.Open(TestFileName))
    {
      var openXml = document.WordprocessingDocument!.MainDocumentPart!.NumberingDefinitionsPart!.Numbering!.OuterXml;
      var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
      Console.WriteLine(formattedOpenXml);
      var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
      if (!validationResult.IsValid)
      {
        Console.WriteLine("✗ NumberingInstances OpenXml schema validation FAILED - issues found:");
        foreach (var msg in validationResult.Messages)
        {
          Console.WriteLine($" {msg}");
        }
        return false;
      }
    }

    Numbering storedData;
    using (var document = Document.Open(TestFileName))
    {
      storedData = document.Numbering ?? throw new InvalidOperationException("Numbering not found.");
    }

    var xmlSerializer = new XmlSerializer(typeof(Numbering));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("Updated document NumberingInstances:\n" + xmlString);

    var storedCount = storedData.NumberingInstances.Count;
    if (storedCount != initialCount + 1)
    {
      Console.WriteLine($"✗ Updated document NumberingInstances test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
      return false;
    }

    Console.WriteLine("✓ Updated document NumberingInstances test passed\n");
    return true;
  }

  /// <summary>
  /// Creates a sample Numbering object with various property types.
  /// </summary>
  /// <returns>A populated Numbering object.</returns>
  private Numbering CreateSampleNumbering()
  {
    var Numbering = new Numbering
    {
      NumberingInstances = CreateSampleNumberingInstances(),
    };
    return Numbering;
  }

  /// <summary>
  /// Creates a collection of sample abstract numbering for use in document formatting.
  /// </summary>
  /// <remarks>This method initializes several abstract numbering with specific properties, such as primary
  /// status and UI priority, to facilitate consistent document styling.</remarks>
  /// <returns>A NumberingInstances object containing predefined abstract numbering, including primary numbering and annotations.</returns>
  private NumberingInstances CreateSampleNumberingInstances()
  {
    var NumberingInstances = new NumberingInstances();
    NumberingInstances.Add(new NumberingInstance()
    {

      AbstractNumId = 1,
      NumberID = 1,
      LevelOverrides = new NumberingLevelOverrides()
      {
        new NumberingLevelOverride()
        {
          LevelIndex = NumLevel.Level1,
          StartOverrideNumberingValue = 1,
        },
        new NumberingLevelOverride()
        {
          LevelIndex = NumLevel.Level3,
          Level = new NumberingLevel()
          {
            LevelIndex = NumLevel.Level3,
            LevelRestart = NumLevel.Level2,
          },
        },

      }
    });

    NumberingInstances.Add(new NumberingInstance()
    {
      AbstractNumId = 2,
      NumberID = 2
    });

    NumberingInstances.Add(new NumberingInstance()
    {
      AbstractNumId = 3,
      NumberID = 3,
    });

    return NumberingInstances;
  }

  /// <summary>
  /// Serializes a Numbering object to an XML string.
  /// </summary>
  /// <param name="props">The Numbering object to serialize.</param>
  /// <returns>The serialized XML string.</returns>
  private string SerializeToXml(Numbering props)
  {
    var xmlSerializer = new XmlSerializer(typeof(Numbering));
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, props);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes a Numbering object from an XML string.
  /// </summary>
  /// <param name="xml">The XML string to deserialize.</param>
  /// <returns>The deserialized Numbering object, or null if deserialization fails.</returns>
  private Numbering? DeserializeFromXml(string xml)
  {
    var xmlSerializer = new XmlSerializer(typeof(Numbering));
    using (var stringReader = new StringReader(xml))
    {
      return (Numbering?)xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Serializes a Numbering object to a JSON string.
  /// </summary>
  /// <param name="props">The Numbering object to serialize.</param>
  /// <returns>The serialized JSON string.</returns>
  private string SerializeToJson(Numbering props)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Serialize(props, jsonOptions);
  }

  /// <summary>
  /// Deserializes a Numbering object from a JSON string.
  /// </summary>
  /// <param name="json">The JSON string to deserialize.</param>
  /// <returns>The deserialized Numbering object, or null if deserialization fails.</returns>
  private Numbering? DeserializeFromJson(string json)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Deserialize<Numbering>(json, jsonOptions);
  }
}