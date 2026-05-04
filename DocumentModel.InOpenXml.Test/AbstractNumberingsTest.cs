using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive test for DocumentModel.Numbering.
  /// </summary>
  public class AbstractNumberingsTest: _AbstractTestClass
  {

    private readonly string TestFileName = Path.Combine(TestFileDir, "AbstractNumberingsTest.docx");

    /// <summary>
    /// Runs all tests and reports the results.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public override bool Run()
    {
      Console.WriteLine("=== AbstractNumberingsTest ===\n");
      //if (!TestXmlSerialization()) return false;
      //if (!TestJsonSerialization()) return false;
      //if (!TestEdgeCases()) return false;
      //if (!TestStoreInDocument()) return false;
      if (!TestUpdateInDocument()) return false;
      if (!TestValidateOpenXml()) return false;
      Console.WriteLine("AbstractNumberingsTest passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of Numbering.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    private bool TestXmlSerialization()
    {
      Console.WriteLine("--- AbstractNumberings Test XML Serialization ---");
      var testData = CreateSampleNumbering();
      var xmlSerializer = new XmlSerializer(typeof(Numbering));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      Numbering? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (Numbering?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ AbstractNumberings Test XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ AbstractNumberings Test XML Serialization/Deserialization test FAILED: {message}");
        return false;
      }
      Console.WriteLine("✓ AbstractNumberings Test XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of Numbering.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    private bool TestJsonSerialization()
    {
      Console.WriteLine("--- AbstractNumberings Test JSON Serialization ---");
      var testData = CreateSampleNumbering();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("AbstractNumberings Test Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<Numbering>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ AbstractNumberings Test JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ AbstractNumberings Test JSON Serialization/Deserialization test FAILED: {message}");
        return false;
      }
      Console.WriteLine("✓ AbstractNumberingsTest JSON Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests edge cases like empty Numbering object.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    private bool TestEdgeCases()
    {
      Console.WriteLine("--- AbstractNumberings Test Edge Cases ---");
      var empty = new Numbering();
      string xml = SerializeToXml(empty);
      var xmlDeserialized = DeserializeFromXml(xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine("✗ AbstractNumberings Test Edge Cases: XML deserialization of empty object failed");
        return false;
      }
      string json = SerializeToJson(empty);
      var jsonDeserialized = DeserializeFromJson(json);
      if (jsonDeserialized == null)
      {
        Console.WriteLine("✗ AbstractNumberings Test Edge Cases: JSON deserialization of empty object failed");
        return false;
      }
      Console.WriteLine("✓ AbstractNumberings Test Edge Cases passed\n");
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
      Console.WriteLine("--- AbstractNumberings Test Store sample abstract numbering in new document---");
      Numbering testData = CreateSampleNumbering();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.Numbering = testData;
      }

      Numbering storedData;
      using (var document = new Document(TestFileName))
      {
        var openXml = document.WordprocessingDocument!.MainDocumentPart!.NumberingDefinitionsPart!.Numbering!.OuterXml;
        //openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
        //  "http://purl.oclc.org/ooxml/wordprocessingml/main");
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);

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
      Console.WriteLine("AbstractNumberings Test: Numbering stored to new document and reloaded from it:\n" + xmlString);

      if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
      {
        Console.WriteLine($"✗ AbstractNumberings Test: Store sample abstract numbering test FAILED: {message}");
        return false;
      }

      Console.WriteLine("✓ AbstractNumberings Test: Store sample abstract numbering test passed\n");
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
      Console.WriteLine("--- AbstractNumberings Test: Update document abstract numbering ---");
      {
        Numbering testData = CreateSampleNumbering();
        var initialCount = testData.AbstractNumberings.Count;
        using (var document = new Document(TestFileName, FileMode.CreateNew))
        {
          document.Numbering = testData;
          document.Numbering.AbstractNumberings.Add(new AbstractNumbering()
          {
            Name = "New numbering",
          });
        }
        Numbering storedData;
        using (var document = new Document(TestFileName))
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
        Console.WriteLine("✓ AbstractNumberings Test: Updated document abstract Numbering:\n" + xmlString);

        var storedCount = storedData.AbstractNumberings.Count;
        if (storedCount != initialCount + 1)
        {
          Console.WriteLine($"✗ AbstractNumberings Test: Updated document abstract numbering test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
          return false;
        }

        Console.WriteLine("✓ AbstractNumberings Test: Updated document abstract numbering test passed\n");
        return true;
      }
    }

    /// <summary>
    /// Tests validating the OpenXml generated from the document containing sample Numbering against the OpenXml schema.
    /// </summary>
    /// <remarks>This method is intended for use in test scenarios to verify that the OpenXml generated from the document
    /// containing sample Numbering adheres to the OpenXml schema. It writes status messages and the serialized properties to the console for
    /// inspection.</remarks>
    /// <returns>true if the OpenXml is valid according to the schema; otherwise, false.</returns>
    private bool TestValidateOpenXml()
    {
      Console.WriteLine("--- AbstractNumberings Test: Validate sample abstract numbering stored in new document against OpenXml schema ---");
      {
        Numbering testData = CreateSampleNumbering();
        using (var document = new Document(TestFileName, FileMode.CreateNew))
        {
          document.Numbering = testData;
        }

        using (var document = new Document(TestFileName))
        {
          var openXml = document.WordprocessingDocument!.MainDocumentPart!.NumberingDefinitionsPart!.Numbering!.OuterXml;
          //openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
          //  "http://purl.oclc.org/ooxml/wordprocessingml/main");
          var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
          Console.WriteLine(formattedOpenXml);
          var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
          if (!validationResult.IsValid)
          {
            Console.WriteLine("✗ AbstractNumberings Test: OpenXml schema validation FAILED - issues found:");
            foreach (var message in validationResult.Messages)
            {
              Console.WriteLine($" {message}");
            }
            return false;
          }
        }

        Console.WriteLine("✓ AbstractNumberings Test Validate sample abstract numbering test passed\n");
        return true;
      }
    }

    /// <summary>
    /// Creates a sample Numbering object with various property types.
    /// </summary>
    /// <returns>A populated Numbering object.</returns>
    private Numbering CreateSampleNumbering()
    {
      var Numbering = new Numbering
      {
        AbstractNumberings = CreateSampleAbstractNumberings(),
      };
      return Numbering;
    }

    /// <summary>
    /// Creates a collection of sample abstract numbering for use in document formatting.
    /// </summary>
    /// <remarks>This method initializes several abstract numbering with specific properties, such as primary
    /// status and UI priority, to facilitate consistent document styling.</remarks>
    /// <returns>A AbstractNumberings object containing predefined abstract numbering, including primary numbering and annotations.</returns>
    private AbstractNumberings CreateSampleAbstractNumberings()
    {
      var abstractNumberings = new AbstractNumberings();
      abstractNumberings.Add(new AbstractNumbering()
      {
        Name = "Normal",
        NsId = 1,
        AbstractNumId = 1,
        MultiLevelType = MultiLevel.SingleLevel,
        TemplateCode = 101,
        Levels = new NumberingLevels
        {
          new NumberingLevel
          {
            LevelIndex = 0,
            StartNumberingValue = 1,
            NumberingFormat = new NumberingFormat { Type = NumberFormat.Decimal },
            LevelText = new NumberingLevelText { Text = "%1." },
            LevelSuffix = LevelSuffix.Space,
            Justification = LevelJustification.Left,
          }
        },
      });

      abstractNumberings.Add(new AbstractNumbering()
      {
        Name = "Outline",
        NsId = 2,
        AbstractNumId = 2,
        MultiLevelType = MultiLevel.Multilevel,
        TemplateCode = 202,
        StyleLink = "Heading1",
        Levels = new NumberingLevels
        {
          new NumberingLevel
          {
            LevelIndex = 0,
            StartNumberingValue = 1,
            NumberingFormat = new NumberingFormat { Type = NumberFormat.UpperRoman },
            LevelText = new NumberingLevelText { Text = "%1." },
            LevelSuffix = LevelSuffix.Tab,
            Justification = LevelJustification.Left,
            IsLegalNumberingStyle = true,
          },
          new NumberingLevel
          {
            LevelIndex = NumLevel.Level2,
            StartNumberingValue = 1,
            NumberingFormat = new NumberingFormat { Type = NumberFormat.Decimal },
            LevelText = new NumberingLevelText { Text = "%1.%2." },
            LevelSuffix = LevelSuffix.Space,
            Justification = LevelJustification.Left,
          }
        },
      });

      abstractNumberings.Add(new AbstractNumbering()
      {
        Name = "Bullet",
        NsId = 3,
        AbstractNumId = 3,
        MultiLevelType = MultiLevel.HybridMultilevel,
        TemplateCode = 303,
        NumberingStyleLink = "ListBullet",
        Levels = new NumberingLevels
        {
          new NumberingLevel
          {
            LevelIndex = 0,
            NumberingFormat = new NumberingFormat { Type = NumberFormat.Bullet },
            LevelText = new NumberingLevelText { Text = "•" },
            LevelSuffix = LevelSuffix.Space,
            Justification = LevelJustification.Left,
            ParagraphProperties = new NumberingLevelParagraphProperties()
            {
              Justification = Justification.Both,
            }
          }
        },
      });

      return abstractNumberings;
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
}