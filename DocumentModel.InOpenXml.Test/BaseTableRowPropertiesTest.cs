namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive test for BaseTableRowProperties.
  /// </summary>
  public class BaseTableRowPropertiesTest: _AbstractTestClass
  {
    /// <summary>
    /// Paragraphs all BaseTableRowProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== BaseTableRowProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All BaseTableRowProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of BaseTableRowProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(BaseTableRowProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      BaseTableRowProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (BaseTableRowProperties?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableRowProperties), (object)testData, (object)deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED: {message}");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of BaseTableRowProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<BaseTableRowProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseTableRowProperties), (object)testData, (object)deserialized, "testData", "deserialized", out var message))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED: {message}");
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
    /// Creates a sample Styles object with BaseTableRowProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static BaseTableRowProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateBaseTableRowProperties(isUpdated);
    }

    /// <summary>
    /// Creates a sample BaseTableRowProperties object with test data for all properties,
    /// optionally with updated values for update scenarios.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated BaseTableRowProperties object.</returns>
    internal static BaseTableRowProperties CreateBaseTableRowProperties(bool isUpdated = false)
    {
      return new BaseTableRowProperties
      {
        RowHeight = new HeightMeasure
        {
          Value = isUpdated ? 420 : 360,
          Type = isUpdated ? HeightMeasureType.Exact : HeightMeasureType.AtLeast
        },
        CantSplit = true,
        IsHeader = isUpdated,
        RowAlignment = isUpdated ? TableRowAlignment.Center : TableRowAlignment.Left,
        CellSpacing = isUpdated ? new TableMeasure(120) : new TableMeasure(60),
        GlyphHidden = isUpdated,
        GridBefore = isUpdated ? 1 : 0,
        GridAfter = isUpdated ? 2 : 1,
        WidthBefore = isUpdated ? new TableMeasure(720) : new TableMeasure(360),
        WidthAfter = isUpdated ? new TableMeasure(720) : new TableMeasure(360),
        DivId = isUpdated ? "row-div-updated" : "row-div",
        ConditionalFormatStyle = ConditionalFormatFlags.FirstRow | ConditionalFormatFlags.FirstColumn
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
