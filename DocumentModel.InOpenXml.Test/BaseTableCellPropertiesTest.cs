namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive serialization test for BaseTableCellProperties.
  /// </summary>
  public static class BaseTableCellPropertiesTest
  {
    /// <summary>
    /// Paragraphs all BaseTableCellProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== BaseTableCellProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All BaseTableCellProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of BaseTableCellProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(BaseTableCellProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      BaseTableCellProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (BaseTableCellProperties?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableCellProperties), (object)testData, (object)deserialized, out var propName))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of BaseTableCellProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<BaseTableCellProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableCellProperties), (object)testData, (object)deserialized, out var propName))
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
    /// Creates a sample Styles object with BaseTableCellProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static BaseTableCellProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateBaseTableCellProperties(isUpdated);
    }

    /// <summary>
    /// Creates a sample BaseTableCellProperties object with test data for all properties,
    /// optionally with updated values for update scenarios.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated BaseTableCellProperties object.</returns>
    internal static BaseTableCellProperties CreateBaseTableCellProperties(bool isUpdated = false)
    {
      return new BaseTableCellProperties
      {
        Shading = new Shading
        {
          Pattern = isUpdated ? ShadingPattern.Percent20 : ShadingPattern.Percent10,
          ForegroundColor = isUpdated ? "333333" : "666666",
          BackgroundColor = isUpdated ? "DDDDDD" : "F2F2F2"
        },
        NoWrap = isUpdated,
        TableCellMargin = new TableCellMargin
        {
          TopMargin = new TableMeasure { Value = 120, Type = TableMeasureType.Absolute },
          LeftMargin = new TableMeasure { Value = 50, Type = TableMeasureType.Percent },
          StartMargin = new TableMeasure { Value = 180, Type = TableMeasureType.Absolute },
          BottomMargin = new TableMeasure { Type = TableMeasureType.Auto },
          RightMargin = new TableMeasure { Type = TableMeasureType.Nil },
          EndMargin = new TableMeasure { Value = 240, Type = TableMeasureType.Absolute },
        },
        TableCellVerticalAlignment = isUpdated ? TableVerticalAlignment.Center : TableVerticalAlignment.Top
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
