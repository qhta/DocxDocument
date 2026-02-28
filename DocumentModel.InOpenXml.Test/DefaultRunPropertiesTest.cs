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
  /// Comprehensive serialization test for Styles DefaultRunProperties.
  /// </summary>
  public static class DefaultRunPropertiesTest
  {
    /// <summary>
    /// Runs all Styles DefaultRunProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== Styles DefaultRunProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All Styles DefaultRunProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of Styles DefaultRunProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(DefaultRunProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      DefaultRunProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (DefaultRunProperties?)xmlSerializer.Deserialize(stringReader);
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
    /// Tests JSON serialization and deserialization of Styles DefaultRunProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<DefaultRunProperties>(jsonString, jsonOptions);
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
    /// <summary>
    /// Creates a sample Styles object with DefaultRunProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static DefaultRunProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateSampleRunProperties(isUpdated);
    }

    /// <summary>
    /// This method is used also in StyleDocDefaultsRunPropertiesTest.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated DefaultRunProperties object.</returns>
    internal static DefaultRunProperties CreateSampleRunProperties(bool isUpdated = false)
    {
      return new DefaultRunProperties
      {
        RunFonts = new RunFonts
        {
          Ascii = "Times New Roman",
          HighAnsi = "Times New Roman",
          ComplexScript = "Arial",
          EastAsia = "Arial"
        },
        Bold = true,
        BoldCS = true,
        Italic = true,
        ItalicCS = false,
        FontSize = isUpdated ? 28 : 24,
        FontSizeCS = isUpdated ? new HPS("12 pt") : "10 pt",
        Caps = isUpdated ? false : true,
        SmallCaps = true,
        Strike = true,
        DoubleStrike = isUpdated ? true : null,
        Color = isUpdated ? new DMW.Color("00AA00") : new DMW.Color { Val = "000000", ThemeColor = ThemeColors.Text1 },
        Underline = new Underline { Type = UnderlineType.Wave, Color = "FF0000" }, 
        Spacing = isUpdated ? new Twips(30) : new Twips(20),
        CharacterScale = isUpdated ? new Percent(115) : new Percent(110),
        NoProof = true,
        Kern = isUpdated ? new HPS("10 pt") : new HPS("12 pt"), 
        Language = isUpdated ? "en-US" : new Languages("fr-FR", "ar-SA", "ja-JP"),
        Border = new DMW.Border
        {
          Style = BorderStyle.Dash,
          Color = "0000FF",
          Width = "0.5pt",
          Space = "0.25pt",
          Shadow = true,
          Frame = false,
        },
        TextEffect = isUpdated ? TextEffect.BlinkBackground : TextEffect.None,
        FitText = new FitText { Id = 50, Width = "0.5in" },
        Emphasis = isUpdated ? EmphasisMark.Circle : EmphasisMark.None,
      };
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
}
