namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive test for Styles BaseSectionProperties.
  /// </summary>
  public class BaseSectionPropertiesTest: AbstractTestClass
  {
    /// <summary>
    /// Paragraphs all Styles BaseSectionProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== BaseSectionProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All BaseSectionProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of Styles BaseSectionProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(BaseSectionProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      BaseSectionProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (BaseSectionProperties?)xmlSerializer.Deserialize(stringReader);
      }
      if (deserialized == null)
      {
        Console.WriteLine("✗ XML Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseSectionProperties), (object)testData, (object)deserialized, out var propName))
      {
        Console.WriteLine($"✗ XML Serialization/Deserialization test FAILED - data mismatch in '{propName}'");
        return false;
      }
      Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
      return true;
    }

    /// <summary>
    /// Tests JSON serialization and deserialization of Styles BaseSectionProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<BaseSectionProperties>(jsonString, jsonOptions);
      if (deserialized == null)
      {
        Console.WriteLine("✗ JSON Deserialization returned null");
        return false;
      }
      if (!TestHelper.CompareTestData(typeof(BaseSectionProperties), (object)testData, (object)deserialized, out var propName))
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
    /// Creates a sample Styles object with BaseSectionProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static BaseSectionProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateBaseSectionProperties(isUpdated);
    }

    /// <summary>
    /// Creates a sample BaseSectionProperties object with test data for all properties,
    /// optionally with updated values for update scenarios.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated BaseSectionProperties object.</returns>
    internal static BaseSectionProperties CreateBaseSectionProperties(bool isUpdated = false)
    {
      return new BaseSectionProperties
      {
        RsidRPr = isUpdated ? new HexInt(0x1001) : new HexInt(0x0001),
        RsidDel = isUpdated ? new HexInt(0x1002) : new HexInt(0x0002),
        RsidR = isUpdated ? new HexInt(0x1003) : new HexInt(0x0003),
        RsidSect = isUpdated ? new HexInt(0x1004) : new HexInt(0x0004),
        SectionType = isUpdated ? SectionStart.EvenPage : SectionStart.NextPage,
        FormProtection = isUpdated,
        VerticalTextAlignmentOnPage = isUpdated ? VerticalJustification.Bottom : VerticalJustification.Top,
        NoEndnote = true,
        TitlePage = true,
        TextDirection = isUpdated ? TextDirection.TopToBottomVertical : TextDirection.LeftToRight,
        BiDi = true,
        GutterOnRight = isUpdated,
        FootnoteColumns = isUpdated ? 2 : 1,
        FootnoteProperties = new FootnoteProperties
        {
          NumberingStart = (ushort)(isUpdated ? 2 : 1)
        },
        EndnoteProperties = new EndnoteProperties
        {
          NumberingStart = (ushort)(isUpdated ? 2 : 1)
        },
        PageSize = new PageSize
        {
          Width = isUpdated ? 16838 : 11906,
          Height = isUpdated ? 11906 : 16838
        },
        PageMargin = new PageMargin
        {
          Top = isUpdated ? 1440 : 1134,
          Right = isUpdated ? 1080 : 720,
          Bottom = isUpdated ? 1440 : 1134,
          Left = isUpdated ? 1080 : 720,
          Header = 720,
          Footer = 720,
          Gutter = isUpdated ? 180 : 0
        },
        PaperSource = new PaperSource
        {
          First = (ushort)(isUpdated ? 2 : 1),
          Other = (ushort)(isUpdated ? 3 : 2)
        },
        PageBorders = new PageBorders
        {
          TopBorder = new Border { Type = BorderType.Single, Color = "000000", Width = 4, Space = "2mm" },
          LeftBorder = new Border { Type = BorderType.Dashed, Color = "00AA00", Width = 3, Space = "2mm" },
          BottomBorder = new Border { Type = BorderType.Double, Color = "0000AA", Width = 4, Space = "2mm" },
          RightBorder = new Border { Type = BorderType.DotDash, Color = "AA0000", Width = 3, Space = "2mm" }
        },
        LineNumberType = new LineNumberType
        {
          CountBy = 1,
          Start = (short)(isUpdated ? 2 : 1),
          Distance = isUpdated ? "360" : "240"
        },
        PageNumberType = new PageNumberType
        {
          Start = isUpdated ? 3 : 1,
          ChapterStyle = 1
        },
        Columns = new TextColumns
        {
          EqualWidth = true,
          Space = 720,
          ColumnCount = isUpdated ? 3 : 2,
          Separator = true
        },
        DocGrid = new DocGrid
        {
          LinePitch = isUpdated ? 360 : 312,
          CharacterSpace = isUpdated ? 200 : 100
        },
        PrinterSettingsReference = new PrinterSettingsReference
        {
          Id = isUpdated ? "rIdUpdatedPrinterSettings" : "rIdPrinterSettings"
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
