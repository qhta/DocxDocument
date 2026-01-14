using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;

namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive serialization test for DocumentModel.StatisticProperties.
  /// </summary>
  public static class StatisticPropertiesSerializationTest
  {
    public static bool Run()
    {
      Console.WriteLine("=== StatisticProperties Serialization Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;
      Console.WriteLine("All StatisticProperties serialization tests passed.\n");
      return true;
    }

    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleStatisticProperties();
      string xmlString;
      try
      {
        var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
        using (var stringWriter = new StringWriter())
        using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
        {
          xmlSerializer.Serialize(xmlWriter, testData);
          xmlString = stringWriter.ToString();
        }
        Console.WriteLine("Serialized XML:\n" + xmlString.Substring(0, System.Math.Min(1000, xmlString.Length)));
        if (xmlString.Length > 1000) Console.WriteLine("...");

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
        if (!CompareStatisticProperties(testData, deserialized))
        {
          Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
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

    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleStatisticProperties();
      try
      {
        var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
        Console.WriteLine("Serialized JSON:\n" + jsonString.Substring(0, System.Math.Min(1000, jsonString.Length)));
        if (jsonString.Length > 1000) Console.WriteLine("...");

        var deserialized = JsonSerializer.Deserialize<StatisticProperties>(jsonString, jsonOptions);
        if (deserialized == null)
        {
          Console.WriteLine("✗ JSON Deserialization returned null");
          return false;
        }
        if (!CompareStatisticProperties(testData, deserialized))
        {
          Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
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

    static bool TestEdgeCases()
    {
      Console.WriteLine("--- Edge Cases ---");
      try
      {
        var empty = new StatisticProperties();
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

    static bool CompareStatisticProperties(StatisticProperties a, StatisticProperties b)
    {
      return a.Pages == b.Pages &&
             a.Words == b.Words &&
             a.Characters == b.Characters &&
             a.Lines == b.Lines &&
             a.Paragraphs == b.Paragraphs &&
             a.CharactersWithSpaces == b.CharactersWithSpaces &&
             a.Slides == b.Slides &&
             a.Notes == b.Notes &&
             a.HiddenSlides == b.HiddenSlides &&
             a.MultimediaClips == b.MultimediaClips &&
             a.TotalTime == b.TotalTime;
    }

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

    static StatisticProperties? DeserializeFromXml(string xml)
    {
      var xmlSerializer = new XmlSerializer(typeof(StatisticProperties));
      using (var stringReader = new StringReader(xml))
      {
        return (StatisticProperties?)xmlSerializer.Deserialize(stringReader);
      }
    }

    static string SerializeToJson(StatisticProperties props)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Serialize(props, jsonOptions);
    }

    static StatisticProperties? DeserializeFromJson(string json)
    {
      var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
      return JsonSerializer.Deserialize<StatisticProperties>(json, jsonOptions);
    }
  }
}