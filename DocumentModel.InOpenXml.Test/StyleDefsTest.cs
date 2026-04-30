namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Styles.
/// </summary>
public class StyleDefsTest: _AbstractTestClass
{
  private static readonly string TestFileName = Path.Combine(TestFileDir, "StyleDefsTest.docx");

  /// <summary>
  /// Runs all Styles serialization tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== StyleDefs Test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    if (!TestValidateOpenXml()) return false;
    Console.WriteLine("All Styles tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization of Styles.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestXmlSerialization()
  {
    Console.WriteLine("--- XML Serialization ---");
    var testData = CreateSampleStyles();
    var xmlSerializer = new XmlSerializer(typeof(Styles));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("Serialized XML:\n" + xmlString);

    Styles? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (Styles?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine("✗ XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
    {
      Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
      return false;
    }
    Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization of Styles.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestJsonSerialization()
  {
    Console.WriteLine("--- JSON Serialization ---");
    var testData = CreateSampleStyles();
    var jsonOptions = JsonConfig.Options;
    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
    Console.WriteLine("Serialized JSON:\n" + jsonString);

    var deserialized = JsonSerializer.Deserialize<Styles>(jsonString, jsonOptions);
    if (deserialized == null)
    {
      Console.WriteLine("✗ JSON Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
    {
      Console.WriteLine($"✗ JSON Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
      return false;
    }
    Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases like empty Styles object.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestEdgeCases()
  {
    Console.WriteLine("--- Edge Cases ---");
    var empty = new Styles();
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

  /// <summary>
  /// Tests setting sample Styles to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Styles can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Styles are successfully stored and verified; otherwise, false.</returns>
  static bool TestStoreInDocument()
  {
    Console.WriteLine("--- Store sample StyleDefs in new document---");
    Styles testData = CreateSampleStyles();
    using (var document = new Document(TestFileName, FileMode.CreateNew))
    {
      document.Styles = testData;
    }

    Styles storedData;
    using (var document = new Document(TestFileName))
    {
      storedData = document.Styles ?? throw new InvalidOperationException("Styles not found.");
    }

    var xmlSerializer = new XmlSerializer(typeof(Styles));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("Styles stored to new document and reloaded from it:\n" + xmlString);

    if (!TestHelper.CompareTestData(testData, storedData, out var propName))
    {
      Console.WriteLine($"✗ Store sample StyleDefs test FAILED - data mismatch in '{propName}'");
      return false;
    }

    Console.WriteLine("✓ Store sample StyleDefs test passed\n");
    return true;
  }
    
  /// <summary>
  /// Tests updating the Styles of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document Styles can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document Styles are successfully updated and verified; otherwise, false.</returns>
  static bool TestUpdateInDocument()
  {
    Console.WriteLine("--- Update document StyleDefs ---");
    {
      Styles testData = CreateSampleStyles();
      var initialCount = testData.DefinedStyles.Count;
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.Styles = testData;
        var newStyle = new StyleDef() { StyleName = "New Style" };
        document.Styles.DefinedStyles.Add(newStyle);
      }
      Styles storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.Styles ?? throw new InvalidOperationException("Styles not found.");
      }

      var xmlSerializer = new XmlSerializer(typeof(Styles));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Updated document StyleDefs:\n" + xmlString);

      var storedCount = storedData.DefinedStyles.Count;
      if (storedCount != initialCount + 1)
      {
        Console.WriteLine($"✗ Updated document StyleDefs test FAILED  - new property count is {storedCount}, expected {initialCount + 1}");
        return false;
      }

      Console.WriteLine("✓ Updated document Styles test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests validating the OpenXml generated from the document containing sample Styles against the OpenXml schema.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that the OpenXml generated from the document
  /// containing sample Styles adheres to the OpenXml schema. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the OpenXml is valid according to the schema; otherwise, false.</returns>
  static bool TestValidateOpenXml()
  {
    Console.WriteLine("--- Validate sample StyleDefs stored in new document against OpenXml schema ---");
    {
      Styles testData = CreateSampleStyles();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.Styles = testData;
      }

      using (var document = new Document(TestFileName))
      {
        var openXml = document.WordprocessingDocument!.MainDocumentPart!.StyleDefinitionsPart!.Styles!.OuterXml;
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

      Console.WriteLine("✓ Validate sample StyleDefs test passed\n");
      return true;
    }
  }
    
  /// <summary>
  /// Creates a sample Styles object with various property types.
  /// </summary>
  /// <returns>A populated Styles object.</returns>
  internal static Styles CreateSampleStyles()
  {
    var Styles = new Styles();
    Styles.DefinedStyles.Add(new StyleDef()
    {
      StyleName = "Normal",
      Type = StyleType.Paragraph,
      IsDefault = true,
      IsPrimary = true,
      UIPriority = 1,
    });
    Styles.DefinedStyles.Add(new StyleDef()
    {
      StyleName = "Heading 1",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 9,
    });
    Styles.DefinedStyles.Add(new StyleDef()
    {
      StyleName = "Heading 6",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 14,
    });
    Styles.DefinedStyles.Add(new StyleDef()
    {
      StyleName = "annotation text",
      Type = StyleType.Character,
      IsCustom = true,
      BasedOn = "DefaultParagraphFont",
      UIPriority = 99,
    });
    Styles.DefinedStyles.Add(new StyleDef()
    {
      StyleName = "Book title",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 22,
      IsHidden = StyleHide.Hidden | StyleHide.UnhiddenWhenUsed ,
    });

    return Styles;
  }

  /// <summary>
  /// Serializes a Styles object to an XML string.
  /// </summary>
  /// <param name="props">The Styles object to serialize.</param>
  /// <returns>The serialized XML string.</returns>
  static string SerializeToXml(Styles props)
  {
    var xmlSerializer = new XmlSerializer(typeof(Styles));
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, props);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes a Styles object from an XML string.
  /// </summary>
  /// <param name="xml">The XML string to deserialize.</param>
  /// <returns>The deserialized Styles object, or null if deserialization fails.</returns>
  static Styles? DeserializeFromXml(string xml)
  {
    var xmlSerializer = new XmlSerializer(typeof(Styles));
    using (var stringReader = new StringReader(xml))
    {
      return (Styles?)xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Serializes a Styles object to a JSON string.
  /// </summary>
  /// <param name="props">The Styles object to serialize.</param>
  /// <returns>The serialized JSON string.</returns>
  static string SerializeToJson(Styles props)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Serialize(props, jsonOptions);
  }

  /// <summary>
  /// Deserializes a Styles object from a JSON string.
  /// </summary>
  /// <param name="json">The JSON string to deserialize.</param>
  /// <returns>The deserialized Styles object, or null if deserialization fails.</returns>
  static Styles? DeserializeFromJson(string json)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Deserialize<Styles>(json, jsonOptions);
  }
}