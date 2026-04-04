namespace DocumentModel.InOpenXml.Test
{
  /// <summary>
  /// Comprehensive test for BaseParagraphProperties.
  /// </summary>
  public static class BaseParagraphPropertiesTest
  {
    /// <summary>
    /// Run all BaseParagraphProperties tests.
    /// </summary>
    /// <returns>True if all tests pass; otherwise, false.</returns>
    public static bool Run()
    {
      Console.WriteLine("=== BaseParagraphProperties Test ===\n");
      if (!TestXmlSerialization()) return false;
      if (!TestJsonSerialization()) return false;
      if (!TestEdgeCases()) return false;

      Console.WriteLine("All BaseParagraphProperties tests passed.\n");
      return true;
    }

    /// <summary>
    /// Tests XML serialization and deserialization of BaseParagraphProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestXmlSerialization()
    {
      Console.WriteLine("--- XML Serialization ---");
      var testData = CreateSampleProperties();
      var xmlSerializer = new XmlSerializer(typeof(BaseParagraphProperties));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, testData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Serialized XML:\n" + xmlString);

      BaseParagraphProperties? deserialized;
      using (var stringReader = new StringReader(xmlString))
      {
        deserialized = (BaseParagraphProperties?)xmlSerializer.Deserialize(stringReader);
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
    /// Tests JSON serialization and deserialization of BaseParagraphProperties.
    /// </summary>
    /// <returns>True if the test passes; otherwise, false.</returns>
    static bool TestJsonSerialization()
    {
      Console.WriteLine("--- JSON Serialization ---");
      var testData = CreateSampleProperties();
      var jsonOptions = JsonConfig.Options;
      string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
      Console.WriteLine("Serialized JSON:\n" + jsonString);

      var deserialized = JsonSerializer.Deserialize<BaseParagraphProperties>(jsonString, jsonOptions);
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
    /// Creates a sample Styles object with BaseParagraphProperties.
    /// </summary>
    /// <returns>A populated Styles object.</returns>
    static BaseParagraphProperties CreateSampleProperties(bool isUpdated = false)
    {
      return CreateSampleParagraphProperties(isUpdated);
    }

    /// <summary>
    /// This method is used also in StyleDocDefaultsParagraphPropertiesTest.
    /// </summary>
    /// <param name="isUpdated">Indicates whether to create updated sample properties for update scenarios.</param>
    /// <returns>A populated BaseParagraphProperties object.</returns>
    internal static BaseParagraphProperties CreateSampleParagraphProperties(bool isUpdated = false)
    {
      return new BaseParagraphProperties
      {
        KeepNext = isUpdated,
        KeepLines = true,
        PageBreakBefore = true,
        WidowControl = true,
        SuppressLineNumbers = true,
        SuppressAutoHyphens = true,
        Kinsoku = true,
        WordWrap = true,
        OverflowPunctuation = true,
        TopLinePunctuation = true,
        AutoSpaceDE = true,
        AutoSpaceDN = true,
        BiDi = true,
        AdjustRightIndent = true,
        SnapToGrid = true,
        SpacingByContext = true,
        MirrorIndents = true,
        SuppressOverlap = true,
        Justification = isUpdated ? Justification.Center : Justification.Start,
        TextDirection = isUpdated ? TextDirection.TopToBottom : TextDirection.LeftToRight,
        VerticalTextAlignment = isUpdated ? VerticalTextAlignment.Center : VerticalTextAlignment.Top,
        TextBoxTightWrap = TextBoxTightWrap.AllLines,
        OutlineLevel = isUpdated ? OutlineLevel.Level2 : OutlineLevel.Level1,
        Indentation = new Indentation
        {
          Start = isUpdated ? "720" : "480",
          Hanging = isUpdated ? "360" : "240"
        },
        SpacingBefore = new ParagraphSpacing { Val = isUpdated ? "200" : "100" },
        SpacingAfter = new ParagraphSpacing { Lines = isUpdated ? 150 : 100, AutoSpacing = isUpdated },
        SpacingInterline = new Interline { Line = isUpdated ? "360" : "240", LineRule = LineSpacingRule.AtLeast },
        Borders = new ParagraphBorders
        {
          TopBorder = new Border { Type = BorderType.Single, /* Color = "FF0000", Width = 4, Space = "2mm"*/ },
          LeftBorder = new Border { Type = BorderType.Dashed, Color = "00FF00", Width = 2, Space = "2mm" },
          BottomBorder = new Border { Type = BorderType.DotDash, Color = "0000FF", Width = 3, Space = "2mm" },
          RightBorder = new Border { Type = BorderType.Double, Color = "FFFF00", Width = 5, Space = "2mm" }
        },
        Shading = new Shading { Pattern = ShadingPattern.Percent10, ForegroundColor = "CCCCCC", BackgroundColor = "333333", },
        Tabs = new Tabs(
        [
          new TabStop { Type = TabStopType.Center, Position = 720, Leader = TabStopLeader.Dot }
        ]),
        NumberingProperties = new NumberingProperties
        {
          NumberingId = 1,
          NumberingLevelReference = 0,
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
