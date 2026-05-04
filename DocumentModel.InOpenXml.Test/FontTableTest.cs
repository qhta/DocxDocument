namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Fonts.
/// </summary>
public class FontTableTest: _AbstractTestClass
{
  private static readonly string TestFileName = Path.Combine(TestFileDir, "FontTableTest.docx");

  /// <summary>
  /// Runs all Fonts serialization tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== Fonts Test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    if (!TestValidateOpenXml()) return false;
    Console.WriteLine("All Fonts tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization of Fonts.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestXmlSerialization()
  {
    Console.WriteLine("--- FontTableTest XML Serialization ---");
    var testData = CreateSampleFonts();
    {
      var xmlSerializer = new XmlSerializer(typeof(FontTable));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("FontTableTest Serialized XML:\n" + xmlString);

      FontTable? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (FontTable?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ FontTableTest XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ FontTableTest XML Serialization/Deserialization test FAILED: {message}");
        return false;
      }
      Console.WriteLine("✓ FontTableTest XML Serialization/Deserialization test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests JSON serialization and deserialization of Fonts.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestJsonSerialization()
  {
    Console.WriteLine("--- FontTableTest JSON Serialization ---");
    var testData = CreateSampleFonts();
    {
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("FontTableTest Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<FontTable>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ FontTableTest JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ FontTableTest JSON Serialization/Deserialization test FAILED: {message}");
        return false;
      }
      Console.WriteLine("✓ FontTableTest JSON Serialization/Deserialization test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests edge cases like empty Fonts object.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestEdgeCases()
  {
    Console.WriteLine("--- FontTableTest Edge Cases ---");
    {
      var empty = new FontTable();
      string xml = SerializeToXml(empty);
      var xmlDeserialized = DeserializeFromXml(xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine("✗ FontTableTest Edge Cases: XML deserialization of empty object failed");
        return false;
      }
      string json = SerializeToJson(empty);
      var jsonDeserialized = DeserializeFromJson(json);
      if (jsonDeserialized == null)
      {
        Console.WriteLine("✗ FontTableTest Edge Cases: JSON deserialization of empty object failed");
        return false;
      }
      Console.WriteLine("✓ FontTableTest Edge case tests passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests setting sample Fonts to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Fonts can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Fonts are successfully stored and verified; otherwise, false.</returns>
  static bool TestStoreInDocument()
  {
    Console.WriteLine("--- Store sample Fonts in new document---");
    {
      FontTable testData = CreateSampleFonts();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.FontTable = testData;
      }

      using (var wordDoc = DXPP.WordprocessingDocument.Open(TestFileName, false))
      {
        var outerXml = wordDoc.MainDocumentPart?.FontTablePart?.Fonts?.OuterXml;
        outerXml = outerXml?.FormatXmlWithLineNumbers();
        Console.WriteLine("✓ Fonts stored in document:\n" + outerXml);
      }

      FontTable storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.FontTable ?? throw new InvalidOperationException("Fonts not found.");
      }

      var xmlSerializer = new XmlSerializer(typeof(FontTable));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Fonts stored to new document and reloaded from it:\n" + xmlString);

      if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
      {
        Console.WriteLine($"✗ Store sample Fonts test FAILED: {message}");
        return false;
      }

      Console.WriteLine("✓ Store sample Fonts test passed\n");
      return true;
    }
  }


  /// <summary>
  /// Tests updating the Fonts of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Fonts can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Fonts are successfully updated and verified; otherwise, false.</returns>
  static bool TestUpdateInDocument()
  {
    Console.WriteLine("--- Update document Fonts ---");
    {
      FontTable testData = CreateSampleFonts();
      var initialCount = testData.Count;
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.FontTable = testData;
        document.FontTable.Add(CreateOneFont());
      }

      using (var wordDoc = DXPP.WordprocessingDocument.Open(TestFileName, false))
      {
        var outerXml = wordDoc.MainDocumentPart?.FontTablePart?.Fonts?.OuterXml;
        outerXml = outerXml?.FormatXmlWithLineNumbers();
        Console.WriteLine("✓ Fonts stored in document:\n" + outerXml);
      }

      FontTable storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.FontTable ?? throw new InvalidOperationException("Fonts not found.");
      }

      var xmlSerializer = new XmlSerializer(typeof(FontTable));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Updated document Fonts:\n" + xmlString);

      var storedCount = storedData.Count;
      if (storedCount != initialCount + 1)
      {
        Console.WriteLine($"✗ Updated document Fonts test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
        return false;
      }

      Console.WriteLine("✓ Updated document Fonts test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests validating the OpenXml generated from the document containing sample Fonts against the OpenXml schema.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that the OpenXml generated from the document
  /// containing sample Fonts adheres to the OpenXml schema. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the OpenXml is valid according to the schema; otherwise, false.</returns>
  static bool TestValidateOpenXml()
  {
    Console.WriteLine("--- Validate sample Fonts stored in new document against OpenXml schema ---");
    {
      FontTable testData = CreateSampleFonts();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.FontTable = testData;
      }

      using (var document = new Document(TestFileName))
      {
        var openXml = document.WordprocessingDocument!.MainDocumentPart!.FontTablePart!.Fonts!.OuterXml;
        //openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
        //  "http://purl.oclc.org/ooxml/wordprocessingml/main");
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);
        var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
        if (!validationResult.IsValid)
        {
          Console.WriteLine("✗ OpenXml schema validation FAILED - issues found:");
          foreach (var message in validationResult.Messages)
          {
            Console.WriteLine($" {message}");
          }
          return false;
        }
      }

      Console.WriteLine("✓ Validate sample Fonts test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Creates a sample Fonts object with various property types.
  /// </summary>
  /// <returns>A populated Fonts object.</returns>
  static FontTable CreateSampleFonts()
  {
    var fonts = new FontTable();
    fonts.Add(new Font
    {
      FontName = "Arial",
      Aliases = "Helvetica,Swiss",
      FontFamily = FontFamily.Swiss,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.EastEurope,
      Panose = "020B0604020202020204",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
    });
    fonts.Add(new Font
    {
      FontName = "Times New Roman",
      Aliases = "Times",
      FontFamily = FontFamily.Roman,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.Ansi,
      Panose = "02020603050405020304",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000"
    });
    fonts.Add(new Font
    {
      FontName = "Courier New",
      Aliases = "Courier",
      FontFamily = FontFamily.Modern,
      Pitch = FontPitch.Fixed,
      Panose = "02070309020205020404",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000",
      NotTrueType = true,
    });
    return fonts;
  }

  /// <summary>
  /// Creates a new instance of the FontDef class.
  /// </summary>
  static Font CreateOneFont()
  {
    var font = (new Font
    {
      FontName = "Arial",
      Aliases = "Helvetica,Swiss",
      FontFamily = FontFamily.Swiss,
      Pitch = FontPitch.Variable,
      Charset = FontCharset.EastEurope,
      Panose = "020B0604020202020204",
      FontSignature = "E0002EFF-C000785B-00000009-00000000-000001FF-00000000",
      // TODO: Test FontRelationshipType properties when supported by the model and embed the font accordingly
      //EmbedRegularFont =  new FontRelationshipType { Id = "rId1", FontKey = Guid.NewGuid(), Subsetted = false },
    });
    return font;
  }

  /// <summary>
  /// Serializes a Fonts object to an XML string.
  /// </summary>
  /// <param name="props">The Fonts object to serialize.</param>
  /// <returns>The serialized XML string.</returns>
  static string SerializeToXml(FontTable props)
  {
    var xmlSerializer = new XmlSerializer(typeof(FontTable));
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, props);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes a Fonts object from an XML string.
  /// </summary>
  /// <param name="xml">The XML string to deserialize.</param>
  /// <returns>The deserialized Fonts object, or null if deserialization fails.</returns>
  static FontTable? DeserializeFromXml(string xml)
  {
    var xmlSerializer = new XmlSerializer(typeof(FontTable));
    using (var stringReader = new StringReader(xml))
    {
      return (FontTable?)xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Serializes a Fonts object to a JSON string.
  /// </summary>
  /// <param name="props">The Fonts object to serialize.</param>
  /// <returns>The serialized JSON string.</returns>
  static string SerializeToJson(FontTable props)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Serialize(props, jsonOptions);
  }

  /// <summary>
  /// Deserializes a Fonts object from a JSON string.
  /// </summary>
  /// <param name="json">The JSON string to deserialize.</param>
  /// <returns>The deserialized Fonts object, or null if deserialization fails.</returns>
  static FontTable? DeserializeFromJson(string json)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Deserialize<FontTable>(json, jsonOptions);
  }
}