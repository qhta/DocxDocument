namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive test for BaseTableProperties.
  /// </summary>
  public class BaseTablePropertiesTest: _AbstractTestClass
  {
    /// <summary>
    /// Paragraphs all BaseTableProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== BaseTableProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All BaseTableProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of BaseTableProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(BaseTableProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      BaseTableProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (BaseTableProperties?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableProperties), (object)testData, (object)deserialized, out var propName))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of BaseTableProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<BaseTableProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableProperties), (object)testData, (object)deserialized, out var propName))
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
    /// Creates a sample Styles object with BaseTableProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static BaseTableProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateBaseTableProperties(isUpdated);
    }

    /// <summary>
    /// Creates a sample BaseTableProperties object with test data for all properties,
    /// optionally with updated values for update scenarios.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated BaseTableProperties object.</returns>
    internal static BaseTableProperties CreateBaseTableProperties(bool isUpdated = false)
    {
      return new BaseTableProperties
      {
        TableJustification = isUpdated ? TableRowAlignment.Center : TableRowAlignment.Left,
        TableIndentation = isUpdated ? new TableMeasure(720) : new TableMeasure(360),
        DefaultTableCellMargin = new TableCellMargin
        {
          TopMargin = new TableMeasure(120),
          LeftMargin = new TableMeasure(isUpdated ? 180 : 120),
          StartMargin = new TableMeasure(isUpdated ? 180 : 120),
          BottomMargin = new TableMeasure(120),
          RightMargin = new TableMeasure(isUpdated ? 180 : 120),
          EndMargin = new TableMeasure(isUpdated ? 180 : 120)
        },
        TableCellSpacing = isUpdated ? new TableMeasure(80) : new TableMeasure(40),
        TableBorders = new TableBorders
        {
          TopBorder = new Border { Type = BorderType.Single, Color = "000000", Width = 4, Space = "2mm" },
          LeftBorder = new Border { Type = BorderType.Dashed, Color = "00AA00", Width = 3, Space = "2mm" },
          StartBorder = new Border { Type = BorderType.Dashed, Color = "00AA00", Width = 3, Space = "2mm" },
          BottomBorder = new Border { Type = BorderType.Double, Color = "0000AA", Width = 4, Space = "2mm" },
          RightBorder = new Border { Type = BorderType.DotDash, Color = "AA0000", Width = 3, Space = "2mm" },
          EndBorder = new Border { Type = BorderType.DotDash, Color = "AA0000", Width = 3, Space = "2mm" },
          InsideHorizontalBorder = new Border { Type = BorderType.Single, Color = "777777", Width = 2, Space = "1mm" },
          InsideVerticalBorder = new Border { Type = BorderType.Single, Color = "777777", Width = 2, Space = "1mm" }
        },
        Shading = new Shading
        {
          Pattern = isUpdated ? ShadingPattern.Percent20 : ShadingPattern.Percent10,
          ForegroundColor = isUpdated ? "333333" : "666666",
          BackgroundColor = isUpdated ? "DDDDDD" : "F2F2F2"
        }
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
