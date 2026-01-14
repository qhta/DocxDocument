using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive serialization test for DocumentModel.CustomProperties.
  /// </summary>
  public static class CustomPropertiesSerializationTest
  {
    /// <summary>
    /// Runs all CustomProperties serialization tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== CustomProperties Serialization Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      Console.WriteLine("All CustomProperties serialization tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of CustomProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleCustomProperties();
      string xmlString;
      try
      {
        var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Serialized XML:\n" + xmlString.Substring(0, Math.Min(1000, xmlString.Length)));
        if (xmlString.Length > 1000) Console.WriteLine("...");

        CustomProperties? deserialized;
        using (var stringReader = new StringReader(xmlString))
        {
          deserialized = (CustomProperties?)xmlSerializer.Deserialize(stringReader);
        }
        if (deserialized == null)
        {
          Console.WriteLine("✗ XML Deserialization returned null");
          return false;
        }
        if (!CompareCustomProperties(testData, deserialized))
        {
          Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
          return false;
        }
        Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}");
        var internalException = ex.InnerException;
        while (internalException != null)
        {
          Console.WriteLine($"   Inner Exception: {internalException.Message}");
          internalException = internalException.InnerException;
        }
        return false;
      }
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of CustomProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleCustomProperties();
      try
      {
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
        Console.WriteLine("Serialized JSON:\n" + jsonString.Substring(0, Math.Min(1000, jsonString.Length)));
        if (jsonString.Length > 1000) Console.WriteLine("...");

        var deserialized = JsonSerializer.Deserialize<CustomProperties>(jsonString, jsonOptions);
        if (deserialized == null)
        {
          Console.WriteLine("✗ JSON Deserialization returned null");
          return false;
        }
        if (!CompareCustomProperties(testData, deserialized))
        {
          Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
          return false;
        }
        Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}");
        var internalException = ex.InnerException;
        while (internalException != null)
        {
          Console.WriteLine($"   Inner Exception: {internalException.Message}");
          internalException = internalException.InnerException;
        }
        return false;
      }
    }

    /// <summary>
    /// Tests edge cases like empty CustomProperties object.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      try
      {
        var empty = new CustomProperties();
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
        Console.WriteLine($"✗ Edge case test test FAILED: {ex.Message}");
        var internalException = ex.InnerException;
        while (internalException != null)
        {
          Console.WriteLine($"   Inner Exception: {internalException.Message}");
          internalException = internalException.InnerException;
        }
        return false;
      }
    }

    /// <summary>
    /// Creates a sample CustomProperties object with various property types.
    /// </summary>
    /// <returns>A populated CustomProperties object.</returns>
    static CustomProperties CreateSampleCustomProperties()
    {
      var props = new CustomProperties();
      props.Add(new CustomProperty
      {
        Name = "CustomString",
        PropertyId = 2,
        FormatId = new Guid("D5CDD505-2E9C-101B-9397-08002B2CF9AE"),
        Value = "Test String"
      });
      props.Add(new CustomProperty
      {
        Name = "CustomInt",
        PropertyId = 3,
        FormatId = new Guid("D5CDD505-2E9C-101B-9397-08002B2CF9AE"),
        Value = 123
      });
      props.Add(new CustomProperty
      {
        Name = "CustomDate",
        PropertyId = 4,
        FormatId = new Guid("D5CDD505-2E9C-101B-9397-08002B2CF9AE"),
        Value = new DateTime(2024, 1, 1, 12, 0, 0)
      });
      props.Add(new CustomProperty
      {
        Name = "CustomBool",
        PropertyId = 5,
        FormatId = new Guid("D5CDD505-2E9C-101B-9397-08002B2CF9AE"),
        Value = true
      });
      return props;
    }

    /// <summary>
    /// Compares two CustomProperties objects for equality.
    /// </summary>
    /// <param name="a">The first CustomProperties object.</param>
    /// <param name="b">The second CustomProperties object.</param>
    /// <returns>True if both objects are equivalent; otherwise, false.</returns>
    static bool CompareCustomProperties(CustomProperties a, CustomProperties b)
    {
      if (a.Count != b.Count)
        return false;
      for (int i = 0; i < a.Count; i++)
      {
        var propA = a[i];
        var propB = b[i];
        if (propA.Name != propB.Name 
            ||
            propA.PropertyId != propB.PropertyId
            ||
            propA.FormatId != propB.FormatId
            ||
            !object.Equals(propA.Value, propB.Value)
            )
          return false;
      }
      return true;
    }

    /// <summary>
    /// Serializes a CustomProperties object to an XML string.
    /// </summary>
    /// <param name="props">The CustomProperties object to serialize.</param>
    /// <returns>The serialized XML string.</returns>
    static string SerializeToXml(CustomProperties props)
    {
      var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, props);
        return stringWriter.ToString();
      }
    }

    /// <summary>
    /// Deserializes a CustomProperties object from an XML string.
    /// </summary>
    /// <param name="xml">The XML string to deserialize.</param>
    /// <returns>The deserialized CustomProperties object, or null if deserialization fails.</returns>
    static CustomProperties? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(CustomProperties));
      using (var stringReader = new StringReader(xml))
      {
        return (CustomProperties?)xmlSerializer.Deserialize(stringReader);
      }
    }

    /// <summary>
    /// Serializes a CustomProperties object to a JSON string.
    /// </summary>
    /// <param name="props">The CustomProperties object to serialize.</param>
    /// <returns>The serialized JSON string.</returns>
    static string SerializeToJson(CustomProperties props)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(props, jsonOptions);
    }

    /// <summary>
    /// Deserializes a CustomProperties object from a JSON string.
    /// </summary>
    /// <param name="json">The JSON string to deserialize.</param>
    /// <returns>The deserialized CustomProperties object, or null if deserialization fails.</returns>
    static CustomProperties? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<CustomProperties>(json, jsonOptions);
    }
  }
}