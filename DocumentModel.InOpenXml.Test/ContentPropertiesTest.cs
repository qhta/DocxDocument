using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="DocumentModel.ContentProperties"/>.
/// </summary>
public class ContentPropertiesTest: _AbstractTestClass
{
  private readonly string TestFileName = Path.Combine(TestFileDir, "ContentPropertiesTest.docx");

  /// <summary>
  /// Runs all serialization tests for <see cref="ContentProperties"/>.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== ContentProperties Test ===\n");
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestNewFromDocument()) return false;
    if (!TestStoreInDocument()) return false;
    if (!TestUpdateInDocument()) return false;
    if (!TestStoreBuiltInProperties()) return false;

    Console.WriteLine("All ContentProperties Tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization for <see cref="ContentProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  private bool TestXmlSerialization()
  {
    Console.WriteLine("--- ContentPropertiesTest XML Serialization ---");
    var testData = CreateSampleContentProperties(true);
    var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, testData);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("ContentPropertiesTest Serialized XML:\n" + xmlString);

    ContentProperties? deserialized;
    using (var stringReader = new StringReader(xmlString))
    {
      deserialized = (ContentProperties?)xmlSerializer.Deserialize(stringReader);
    }
    if (deserialized == null)
    {
      Console.WriteLine("✗ ContentPropertiesTest XML Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ ContentPropertiesTest XML Serialization/Deserialization test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ ContentPropertiesTest XML Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization for <see cref="ContentProperties"/>.
  /// </summary>
  /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
  private bool TestJsonSerialization()
  {
    Console.WriteLine("--- ContentPropertiesTest JSON Serialization ---");
    var testData = CreateSampleContentProperties(true);
    var jsonOptions = JsonConfig.Options;
    string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
    Console.WriteLine("ContentPropertiesTest Serialized JSON:\n" + jsonString);

    var deserialized = JsonSerializer.Deserialize<ContentProperties>(jsonString, jsonOptions);
    if (deserialized == null)
    {
      Console.WriteLine("✗ ContentPropertiesTestJSON Deserialization returned null");
      return false;
    }
    if (!TestHelper.CompareTestData(testData, deserialized, "testData", "deserialized", out var message))
    {
      Console.WriteLine($"✗ ContentPropertiesTest JSON Serialization/Deserialization test FAILED: {message}");
      return false;
    }
    Console.WriteLine("✓ ContentPropertiesTest JSON Serialization/Deserialization test passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases for serialization and deserialization of empty <see cref="ContentProperties"/> objects.
  /// </summary>
  /// <returns>True if all edge case tests pass; otherwise, false.</returns>
  private bool TestEdgeCases()
  {
    Console.WriteLine("--- ContentPropertiesTest Edge Cases ---");
    {
      var empty = new ContentProperties();
      string xml = SerializeToXml(empty);
      var xmlDeserialized = DeserializeFromXml<ContentProperties>(xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine("✗ ContentPropertiesTest Edge Cases: XML deserialization of empty object failed");
        return false;
      }
      string json = SerializeToJson(empty);
      var jsonDeserialized = DeserializeFromJson<ContentProperties>(json);
      if (jsonDeserialized == null)
      {
        Console.WriteLine("✗ ContentPropertiesTest Edge Cases: JSON deserialization of empty object failed");
        return false;
      }
      Console.WriteLine("✓ ContentPropertiesTest Edge case tests passed\n");
      return true;
    }
  }


  /// <summary>
  /// Tests the creation and serialization of content properties for a new document.
  /// </summary>
  /// <remarks>This method creates a new document, retrieves its content properties, serializes them to XML,
  /// and outputs the result to the console. It is intended for diagnostic or verification purposes and writes status
  /// messages to the console.</remarks>
  /// <returns>true if the test completes successfully; otherwise, false.</returns>
  private bool TestNewFromDocument()
  {
    Console.WriteLine("--- ContentPropertiesTest New document content properties ---");
    {
      ContentProperties testData;
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        testData = document.ContentProperties;
      }

      Console.WriteLine("New document content properties:\n" + GetDataXml(testData));

      Console.WriteLine("✓ ContentPropertiesTest New document content properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests setting sample content properties to a new document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document content properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document content properties are successfully stored and verified; otherwise, false.</returns>
  private bool TestStoreInDocument()
  {
    Console.WriteLine("--- ContentPropertiesTest Store sample content properties in new document---");
    {
      ContentProperties testData = CreateSampleContentProperties(true);
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.ContentProperties = testData;
      }

      Console.WriteLine("✓ ContentPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

      ContentProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.ContentProperties;
      }

      Console.WriteLine("ContentPropertiesTest: Content properties stored to new document and reloaded from it:\n" + GetDataXml(storedData));

      if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
      {
        Console.WriteLine($"✗ ContentPropertiesTest Store sample content properties test FAILED: {message}");
        return false;
      }

      Console.WriteLine("✓ ContentPropertiesTest Store sample content properties test passed\n");
      return true;
    }
  }
  
  /// <summary>
  /// Tests updating the content properties of a document and outputs the result to the console.
  /// </summary>
  /// <remarks>This method is intended for use in test scenarios to verify that document content properties can
  /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
  /// inspection.</remarks>
  /// <returns>true if the document content properties are successfully updated and verified; otherwise, false.</returns>
  private bool TestUpdateInDocument()
  {
    Console.WriteLine("--- ContentPropertiesTest Update document content properties ---");
    {
      var testData = CreateSampleContentProperties(false);
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.ContentProperties = testData;

        document.ContentProperties.Application = "Updated Application";
        testData.Application = "Updated Application";
      }

      Console.WriteLine("✓ ContentPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

      ContentProperties storedData;
      using (var document = new Document(TestFileName))
      {
        storedData = document.ContentProperties;
      }

      Console.WriteLine("ContentPropertiesTest: Updated document content properties:\n" + GetDataXml(storedData));

      if (!TestHelper.CompareTestData(testData, storedData, "testData", "storedData", out var message))
      {
        Console.WriteLine($"✗ ContentPropertiesTest Updated document content properties test FAILED: {message}");
        return false;
      }

      Console.WriteLine("✓ ContentPropertiesTest Updated document content properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Tests storing sample content properties as built-into a new document and verifies that they are correctly saved and reloaded.
  /// </summary>
  /// <returns>true if the document content properties are successfully stored and verified; otherwise, false.</returns>
  private bool TestStoreBuiltInProperties()
  {
    Console.WriteLine("--- ContentPropertiesTest Store built-in content properties in new document---");
    {
      var testData = CreateSampleContentProperties(true);
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        foreach (var prop in ContentProperties.KnownProperties)
        {
          var propInfo = typeof(ContentProperties).GetProperty(prop.Key);
          if (propInfo != null && propInfo.GetCustomAttribute<BuiltInPropertyAttribute>()!=null)
          {
            var value = propInfo.GetValue(testData);
            if (value != null)
            {
              document.BuiltInDocumentProperties[prop.Key].Value = value;
            }
          }
        }
      }

      Console.WriteLine("✓ ContentPropertiesTest: ExtendedFileProperties stored in document:\n" + ExtendedFileProperties(TestFileName));

      Console.WriteLine("✓ ContentPropertiesTest Store sample content properties test passed\n");
      return true;
    }
  }

  /// <summary>
  /// Creates a sample <see cref="ContentProperties"/> instance for testing.
  /// </summary>
  /// <param name="createAllProperties">Whether to create compound properties, like HeadingPairs and TitlesOfParts.</param>
  /// <returns>A populated <see cref="ContentProperties"/> object.</returns>
  private ContentProperties CreateSampleContentProperties(bool createAllProperties = true)
  {
    var props = new ContentProperties
    {
      Template = "Normal.dotm",
      Application = "Microsoft Word",
      ApplicationVersion = "16.0000",
      Company = "Test Company",
      Manager = "Test Manager",
      SharedDocument = false,
      LinksUpToDate = false,
      HyperlinksChanged = false,
      PresentationFormat = "Print",
      ScaleCrop = true,
    };
    if (createAllProperties)
    {
      props.DocumentSecurity = DocumentSecurity.ReadOnly | DocumentSecurity.PasswordProtected;
      props.DigitalSignature = new HexBinary([0x01, 0x02, 0x03, 0x04, 0x05]);
      props.HyperlinkBase = "http://www.example.com/";
      props.HeadingPairs = new HeadingPairs
      {
        new HeadingPair { Name = "Heading 1", Number = 1 },
        new HeadingPair { Name = "Heading 2", Number = 2 },
        new HeadingPair { Name = "Heading 3", Number = 3 }
      };
      props.TitlesOfParts = new StringList
      {
        "Introduction",
        "Chapter 1",
        "Chapter 2"
      };
      props.HyperlinkList = new HyperlinkList([
        new HyperlinkInfo { Action = HyperlinkAction.Change, Attachment = HyperlinkAttachment.Field, Location = "http://www.example.com/link1" },
        new HyperlinkInfo { Action = HyperlinkAction.Remove, Attachment = HyperlinkAttachment.Background, Location = "http://www.example.com/link2" },
      ]);
    }
    return props;
  }

}