using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Provides comprehensive serialization tests for <see cref="DocumentModel.ContentProperties"/>.
  /// </summary>
  public static class ContentPropertiesSerializationTest
  {
    /// <summary>
    /// Runs all serialization tests for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== ContentProperties Serialization Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      Console.WriteLine("All ContentProperties serialization tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleContentProperties();
      string xmlString;
      try
      {
        var xmlSerializer = new XmlSerializer(typeof(ContentProperties));
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
      catch (Exception ex)
      {
        Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    /// <summary>
    /// Tests JSON serialization and deserialization for <see cref="ContentProperties"/>.
    /// </summary>
    /// <returns>True if the round-trip succeeds; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleContentProperties();
      try
      {
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
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
      catch (Exception ex)
      {
        Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    /// <summary>
    /// Tests edge cases for serialization and deserialization of empty <see cref="ContentProperties"/> objects.
    /// </summary>
    /// <returns>True if all edge case tests pass; otherwise, false.</returns>
    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      try
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
      catch (Exception ex)
      {
        Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}\n{ex.GetInternalMessages()}");
        return false;
      }
    }

    /// <summary>
    /// Creates a sample <see cref="ContentProperties"/> instance for testing.
    /// </summary>
    /// <returns>A populated <see cref="ContentProperties"/> object.</returns>
    static ContentProperties CreateSampleContentProperties()
    {
      var props = new ContentProperties
      {
        Template = "Normal.dotm",
        Application = "Microsoft Word",
        ApplicationVersion = "16.0.12345.1000",
        Company = "Test Company",
        Manager = "Test Manager",
        SharedDocument = true,
        LinksUpToDate = false,
        HyperlinksChanged = true,
        DocumentSecurity = DocumentSecurityKind.ReadOnly | DocumentSecurityKind.PasswordProtected,
        DigitalSignature = [0x01, 0x02, 0x03, 0x04, 0x05],
        HeadingPairs = new HeadingPairs
        {
            new HeadingPair{ Name = "Heading 1", Number = 1 },
            new HeadingPair{ Name = "Heading 2", Number = 2 },
            new HeadingPair{ Name = "Heading 3", Number = 3 }
        }
      };
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