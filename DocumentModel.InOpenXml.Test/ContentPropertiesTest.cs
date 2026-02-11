using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;
using DocumentModel.Wordprocessing;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Provides comprehensive serialization tests for <see cref="DocumentModel.ContentProperties"/>.
  /// </summary>
  public static class ContentPropertiesTest
  {
    /// <summary>
    /// Runs all serialization tests for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== ContentProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      if (!TestNewFromDocument()) return false;
      if (!TestStoreInDocument()) return false;
      if (!TestUpdateInDocument()) return false;
      Console.WriteLine("All ContentProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleContentProperties(true);
      {
        var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
        string xmlString;
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Serialized XML:\n" + xmlString);

        ContentProperties? deserialized;
        using (var stringReader = new StringReader(xmlString))
        {
          deserialized = (ContentProperties?)xmlSerializer.Deserialize(stringReader);
        }
        if (deserialized == null)
        {
          Console.WriteLine("✗ XML Deserialization returned null");
          return false;
        }
        if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
        {
          Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
          return false;
        }
        Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
        return true;
      }
    }

    /// <summary>
    /// Tests JSON serialization and deserialization for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleContentProperties(true);
      {
        var jsonOptions = JsonConfig.Options;
        string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
        Console.WriteLine("Serialized JSON:\n" + jsonString);

        var deserialized = JsonSerializer.Deserialize<ContentProperties>(jsonString, jsonOptions);
        if (deserialized == null)
        {
          Console.WriteLine("✗ JSON Deserialization returned null");
          return false;
        }
        if (!TestHelper.CompareTestData(testData, deserialized, out var propName))
        {
          Console.WriteLine($"✗ JSON Serialization/Deserialization test FAILED - data mismatch in property '{propName}'");
          return false;
        }
        Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
        return true;
      }
    }

    /// <summary>
    /// Tests edge cases for serialization and deserialization of empty <see cref="ContentProperties"/> objects.
    /// </summary>
    /// <returns>True if all edge case tests pass; otherwise, false.</returns>
    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      {
        var empty = new ContentProperties();
        string xml = SerializeToXml(empty);
        var xmlDeserialized = DeserializeFromXml(xml);
        if (xmlDeserialized == null)
        {
          Console.WriteLine("✗ Edge case: XML deserialization of empty object failed");
          return false;
        }
        string json = SerializeToJson(empty);
        var jsonDeserialized = DeserializeFromJson(json);
        if (jsonDeserialized == null)
        {
          Console.WriteLine("✗ Edge case: JSON deserialization of empty object failed");
          return false;
        }
        Console.WriteLine("✓ Edge case tests passed\n");
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
    static bool TestNewFromDocument()
    {
      Console.WriteLine("--- New document content properties ---");
      {
        ContentProperties testData;
        using (var document = new Document("temp.docx", FileMode.Create))
        {
          testData = document.ContentProperties;
        }
        var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
        string xmlString;
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("New document content properties:\n" + xmlString);

        Console.WriteLine("✓ New document content properties test passed\n");
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
    static bool TestStoreInDocument()
    {
      Console.WriteLine("--- Store sample content properties in new document---");
      {
        ContentProperties testData = CreateSampleContentProperties(true);
        using (var document = new Document("temp.docx", FileMode.Create))
        {
          document.ContentProperties = testData;
        }

        ContentProperties storedData;
        using (var document = new Document("temp.docx"))
        {
          storedData = document.ContentProperties;
        }

        var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
        string xmlString;
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, storedData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("content properties stored to new document and reloaded from it:\n" + xmlString);

        if (!TestHelper.CompareTestData(testData, storedData, out var propName))
        {
          Console.WriteLine($"✗ Store sample content properties test FAILED - data mismatch in property '{propName}'");
          return false;
        }

        Console.WriteLine("✓ Store sample content properties test passed\n");
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
    static bool TestUpdateInDocument()
    {
      Console.WriteLine("--- Update document content properties ---");
      {
        var testData = CreateSampleContentProperties(false);
        using (var document = new Document("temp.docx", FileMode.Create))
        {
          document.ContentProperties = testData;

          document.ContentProperties.Application = "Updated Application";
          testData.Application = "Updated Application";
        }

        ContentProperties storedData;
        using (var document = new Document("temp.docx"))
        {
          storedData = document.ContentProperties;
        }

        var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
        string xmlString;
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, storedData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Updated document content properties:\n" + xmlString);

        if (!TestHelper.CompareTestData(testData, storedData, out var propName))
        {
          Console.WriteLine($"✗ Updated document content properties test FAILED - data mismatch in property '{propName}'");
          return false;
        }

        Console.WriteLine("✓ Updated document content properties test passed\n");
        return true;
      }
    }


    /// <summary>
    /// Creates a sample <see cref="ContentProperties"/> instance for testing.
    /// </summary>
    /// <param name="createAllProperties">Whether to create compound properties, like HeadingPairs and TitlesOfParts.</param>
    /// <returns>A populated <see cref="ContentProperties"/> object.</returns>
    static ContentProperties CreateSampleContentProperties(bool createAllProperties = true)
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

    /// <summary>
    /// Serializes a <see cref="ContentProperties"/> instance to XML.
    /// </summary>
    /// <param name="props">The <see cref="ContentProperties"/> instance to serialize.</param>
    /// <returns>XML string representation.</returns>
    static string SerializeToXml(ContentProperties props)
    {
      var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, props);
        return stringWriter.ToString();
      }
    }

    /// <summary>
    /// Deserializes a <see cref="ContentProperties"/> instance from XML.
    /// </summary>
    /// <param name="xml">The XML string to deserialize.</param>
    /// <returns>The deserialized <see cref="ContentProperties"/> instance.</returns>
    static ContentProperties? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
      using (var stringReader = new StringReader(xml))
      {
        return (ContentProperties?)xmlSerializer.Deserialize(stringReader);
      }
    }

    /// <summary>
    /// Serializes a <see cref="ContentProperties"/> instance to JSON.
    /// </summary>
    /// <param name="props">The <see cref="ContentProperties"/> instance to serialize.</param>
    /// <returns>JSON string representation.</returns>
    static string SerializeToJson(ContentProperties props)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(props, jsonOptions);
    }

    /// <summary>
    /// Deserializes a <see cref="ContentProperties"/> instance from JSON.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <returns>The deserialized <see cref="ContentProperties"/> instance.</returns>
    static ContentProperties? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<ContentProperties>(json, jsonOptions);
    }
  }
}