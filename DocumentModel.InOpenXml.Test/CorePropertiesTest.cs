using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentModel;
using DocumentModel.Wordprocessing;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive serialization test for DocumentModel.CoreProperties.
  /// </summary>
  public static class CorePropertiesTest
  {
    /// <summary>
    /// Runs all CoreProperties serialization tests and reports the results.
    /// </summary>
    /// <returns>true if all CoreProperties serialization tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== CoreProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      if (!TestNewFromDocument()) return false;
      if (!TestStoreInDocument()) return false;
      if (!TestUpdateInDocument()) return false;

      Console.WriteLine("All CoreProperties tests passed.\n");
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
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleCoreProperties();
      {
        var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
        string xmlString;
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Serialized XML:\n" + xmlString);

        CoreProperties? deserialized;
        using (var stringReader = new StringReader(xmlString))
        {
          deserialized = (CoreProperties?)xmlSerializer.Deserialize(stringReader);
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
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleCoreProperties();
      {
        var jsonOptions = JsonConfig.Options;
        string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
        Console.WriteLine("Serialized JSON:\n" + jsonString);

        var deserialized = JsonSerializer.Deserialize<CoreProperties>(jsonString, jsonOptions);
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
    /// Tests serialization and deserialization edge cases for empty objects using both XML and JSON formats.
    /// </summary>
    /// <remarks>This method writes diagnostic messages to the console indicating the success or failure of
    /// each edge case test. It is intended for use in verifying that serialization and deserialization logic correctly
    /// handles empty objects without errors.</remarks>
    /// <returns>true if all edge case tests pass; otherwise, false.</returns>
    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      {
        var empty = new CoreProperties();
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
    /// Tests the creation and serialization of core properties for a new document.
    /// </summary>
    /// <remarks>This method creates a new document, retrieves its core properties, serializes them to XML,
    /// and outputs the result to the console. It is intended for diagnostic or verification purposes and writes status
    /// messages to the console.</remarks>
    /// <returns>true if the test completes successfully; otherwise, false.</returns>
    static bool TestNewFromDocument()
    {
      Console.WriteLine("--- New document core properties ---");
      {
        CoreProperties testData;
        using (var document = new Document("temp.docx", FileMode.Create))
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
        Console.WriteLine("New document core properties:\n" + xmlString);

        Console.WriteLine("✓ New document core properties test passed\n");
        return true;
      }
    }

    /// <summary>
    /// Tests setting sample core properties to a new document and outputs the result to the console.
    /// </summary>
    /// <remarks>This method is intended for use in test scenarios to verify that document core properties can
    /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
    /// inspection.</remarks>
    /// <returns>true if the document core properties are successfully stored and verified; otherwise, false.</returns>
    static bool TestStoreInDocument()
    {
      Console.WriteLine("--- Store sample core properties in new document---");
      {
        CoreProperties testData = CreateSampleCoreProperties();
        using (var document = new Document("temp.docx", FileMode.Create))
        {
          document.CoreProperties = testData;
        }

        CoreProperties storedData;
        using (var document = new Document("temp.docx"))
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
        Console.WriteLine("Core properties stored to new document and reloaded from it:\n" + xmlString);

        if (!TestHelper.CompareTestData(testData, storedData, out var propName))
        {
          Console.WriteLine($"✗ Store sample core properties test FAILED - data mismatch in property '{propName}'");
          return false;
        }

        Console.WriteLine("✓ Store sample core properties test passed\n");
        return true;
      }
    }


    /// <summary>
    /// Tests updating the core properties of a document and outputs the result to the console.
    /// </summary>
    /// <remarks>This method is intended for use in test scenarios to verify that document core properties can
    /// be set and serialized correctly. It writes status messages and the serialized properties to the console for
    /// inspection.</remarks>
    /// <returns>true if the document core properties are successfully updated and verified; otherwise, false.</returns>
    static bool TestUpdateInDocument()
    {
      Console.WriteLine("--- Update document core properties ---");
      {
        CoreProperties testData = CreateSampleCoreProperties();
        using (var document = new Document("temp.docx", FileMode.Create))
        {
          document.CoreProperties = testData;

          document.CoreProperties.Title = "Updated Title";
        }

        CoreProperties storedData;
        using (var document = new Document("temp.docx"))
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
        Console.WriteLine("Updated document core properties:\n" + xmlString);

        if (storedData.Title != "Updated Title")
        {
          var propName = "Title";
          Console.WriteLine($"✗ Updated document core properties test FAILED - data mismatch in property '{propName}'");
          return false;
        }

        Console.WriteLine("✓ Updated document core properties test passed\n");
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
    /// core properties.</returns>
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


    /// <summary>
    /// Serializes the specified CoreProperties object to its XML representation.
    /// </summary>
    /// <param name="props">The CoreProperties instance to serialize. Cannot be null.</param>
    /// <returns>A string containing the XML representation of the specified CoreProperties object.</returns>
    static string SerializeToXml(CoreProperties props)
    {
      var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, props);
        return stringWriter.ToString();
      }
    }

    /// <summary>
    /// Deserializes a string containing XML data into a <see cref="CoreProperties"/> object.
    /// </summary>
    /// <param name="xml">A string that contains the XML representation of a <see cref="CoreProperties"/> object. Cannot be null.</param>
    /// <returns>A <see cref="CoreProperties"/> object deserialized from the specified XML string, or <see langword="null"/> if
    /// the XML does not represent a valid <see cref="CoreProperties"/> object.</returns>
    static CoreProperties? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
      using (var stringReader = new StringReader(xml))
      {
        return (CoreProperties?)xmlSerializer.Deserialize(stringReader);
      }
    }

    /// <summary>
    /// Serializes the specified CoreProperties object to a formatted JSON string.
    /// </summary>
    /// <param name="props">The CoreProperties instance to serialize. Cannot be null.</param>
    /// <returns>A JSON-formatted string that represents the specified CoreProperties object.</returns>
    static string SerializeToJson(CoreProperties props)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(props, jsonOptions);
    }

    /// <summary>
    /// Deserializes the specified JSON string into a CoreProperties object.
    /// </summary>
    /// <param name="json">A JSON-formatted string representing the CoreProperties object to deserialize. Cannot be null or empty.</param>
    /// <returns>A CoreProperties object deserialized from the JSON string, or null if the input is invalid or deserialization
    /// fails.</returns>
    static CoreProperties? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<CoreProperties>(json, jsonOptions);
    }
  }
}
