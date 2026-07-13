using System.Runtime.Serialization;

using DocumentModel.Drawings;

using Path = System.IO.Path;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive tests for all DocumentModel types implementing IColor.
/// </summary>
public class ColorTypesTest : BaseThemeTest
{
  /// <summary>
  /// Runs all IColor implementation tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Color Implementations Test ===\n");
    if (!TestColorTypeDiscovery()) return false;
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestColorAccessors()) return false;
    if (!TestEdgeCases()) return false;
    if (!TestColorModelsConversion()) return false;
    if (!StoreThemeInDocument()) return false;
    if (!ChangeColorsInDocument()) return false;

    Console.WriteLine("All Color implementation tests passed.\n");
    return true;
  }

  /// <summary>
  /// Verifies that all known IColor implementations are discovered.
  /// </summary>
  /// <returns>True if discovery is correct; otherwise, false.</returns>
  private bool TestColorTypeDiscovery()
  {
    Console.WriteLine("--- Color Type Discovery ---");
    var discovered = GetIColorTypes();
    var expected = new List<Type>
    {
      typeof(DocumentModel.Drawings.AlphaInverse),
      typeof(DocumentModel.Drawings.BackgroundColor),
      typeof(DocumentModel.Drawings.BulletColor),
      typeof(DocumentModel.Drawings.ColorReplacement),
      typeof(DocumentModel.Drawings.ColorType),
      typeof(DocumentModel.Drawings.ContourColor),
      typeof(DocumentModel.Drawings.CustomColor),
      typeof(DocumentModel.Drawings.Diagrams.ColorType),
      typeof(DocumentModel.Drawings.Diagrams.EffectColorList),
      typeof(DocumentModel.Drawings.Diagrams.FillColor),
      typeof(DocumentModel.Drawings.Diagrams.LineColorList),
      typeof(DocumentModel.Drawings.Diagrams.TextEffectColorList),
      typeof(DocumentModel.Drawings.Diagrams.TextFillColorList),
      typeof(DocumentModel.Drawings.Diagrams.TextLineColorList),
      typeof(DocumentModel.Drawings.Duotone),
      typeof(DocumentModel.Drawings.ExtrusionColor),
      typeof(DocumentModel.Drawings.HslColor),
      typeof(DocumentModel.Drawings.PresetColor),
      typeof(DocumentModel.Drawings.RgbColorModelHex),
      typeof(DocumentModel.Drawings.RgbColorModelPercentage),
      typeof(DocumentModel.Drawings.SchemeColor),
      typeof(DocumentModel.Drawings.SchemeColorDef),
      typeof(DocumentModel.Drawings.SystemColor),
      typeof(DocumentModel.EffectiveColor),
      typeof(DocumentModel.Vml.VmlColor),
      typeof(DocumentModel.Vml.RgbColor),
      typeof(DocumentModel.Wordprocessing.WordColor),
      typeof(DocumentModel.Wordprocessing.RgbColorHex),
      typeof(DocumentModel.Wordprocessing.SchemeColor),
    }.OrderBy(item => item.FullName).ToList();

    if (!discovered.SequenceEqual(expected))

    {
      Console.WriteLine("✗ Color type discovery FAILED");
      Console.WriteLine("Discovered:");
      foreach (var item in discovered) Console.WriteLine($"  {item}");
      Console.WriteLine("Expected:");
      foreach (var item in expected) Console.WriteLine($"  {item}");
      return false;
    }

    Console.WriteLine("✓ Color type discovery passed\n");
    return true;
  }


  private readonly List<Type> typesToTest = new List<Type>
    {
      typeof(DocumentModel.Drawings.HslColor),
      typeof(DocumentModel.Drawings.PresetColor),
      typeof(DocumentModel.Drawings.RgbColorModelHex),
      typeof(DocumentModel.Drawings.RgbColorModelPercentage),
      typeof(DocumentModel.Drawings.SchemeColor),
      typeof(DocumentModel.Drawings.SystemColor),
      typeof(DocumentModel.Wordprocessing.WordColor),
      typeof(DocumentModel.Wordprocessing.RgbColorHex),
      typeof(DocumentModel.Wordprocessing.SchemeColor),
    }.OrderBy(item => item.FullName).ToList();

  /// <summary>
  /// Tests XML serialization and deserialization for all IColor implementations.
  /// </summary>
  /// <returns>True if all XML tests pass; otherwise, false.</returns>
  private bool TestXmlSerialization()
  {
    Console.WriteLine("--- Theme/Color XML Serialization ---");
    var document = CreateDocumentWithInitializedThemePart();
    var theme = document.Theme!;
    var xmlString = SerializeObjectToXml(theme);
    Console.WriteLine($"\nSerialized XML (theme):\n{xmlString}");
    var deserializedTheme = DeserializeObjectFromXml(typeof(Theme), xmlString);
    if (deserializedTheme == null)
    {
      Console.WriteLine($"✗ Xml theme deserialization returned null for '{theme.GetType().Name}'");
      return false;
    }
    if (!TestHelper.CompareTestData(typeof(Theme), theme, deserializedTheme, "testTheme", "deserialized", out var message))
    {
      Console.WriteLine($"✗ Theme/Color XML Serialization/Deserialization test FAILED: {message}");
      return false;
    }

    foreach (var type in typesToTest)
    {
      var color = CreateSampleColor(type);
      AttachToDocumentContext(color, document);
      xmlString = SerializeObjectToXml(color);
      Console.WriteLine($"\nSerialized XML ({type.Name}):\n{xmlString}");

      var deserialized = DeserializeObjectFromXml(color.GetType(), xmlString);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ Theme/Color XML Deserialization returned null for '{type.Name}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(type, color, deserialized, "testColor", "deserialized", out message))
      {
        Console.WriteLine($"✗ Theme/Color XML Serialization/Deserialization test FAILED: {message}");
        return false;
      }
    }

    Console.WriteLine("✓ Theme/Color XML serialization tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization for all IColor implementations.
  /// </summary>
  /// <returns>True if all JSON tests pass; otherwise, false.</returns>
  private bool TestJsonSerialization()
  {
    Console.WriteLine("--- Theme/Color Json Serialization ---");
    var document = CreateDocumentWithInitializedThemePart();
    var theme = document.Theme!;
    var JsonString = SerializeToJson(theme);
    Console.WriteLine($"\nSerialized Json (theme):\n{JsonString}");
    var deserializedTheme = DeserializeFromJson<Theme>(JsonString);
    if (deserializedTheme == null)
    {
      Console.WriteLine($"✗ Json theme deserialization returned null for '{theme.GetType().Name}'");
      return false;
    }
    if (!TestHelper.CompareTestData(typeof(Theme), theme, deserializedTheme, "testTheme", "deserialized", out var message))
    {
      Console.WriteLine($"✗ Theme/Color Json Serialization/Deserialization test FAILED: {message}");
      return false;
    }

    foreach (var type in typesToTest)
    {
      var color = CreateSampleColor(type);
      AttachToDocumentContext(color, document);
      JsonString = SerializeToJson(color);
      Console.WriteLine($"\nSerialized Json ({type.Name}):\n{JsonString}");

      var deserialized = DeserializeFromJson(color.GetType(), JsonString);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ Theme/Color Json Deserialization returned null for '{type.Name}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(type, color, deserialized, "testColor", "deserialized", out message))
      {
        Console.WriteLine($"✗ Theme/Color Json Serialization/Deserialization test FAILED: {message}");
        return false;
      }
    }

    Console.WriteLine("✓ Theme/Color Json serialization tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests common IColor accessors for all implementations.
  /// </summary>
  /// <returns>True if all accessor tests pass; otherwise, false.</returns>
  private bool TestColorAccessors()
  {
    Console.WriteLine("--- Color Accessors ---");
    var document = CreateDocumentWithInitializedThemePart();
    foreach (var type in typesToTest)
    {
      var testData = CreateSampleColor(type);
      AttachToDocumentContext(testData, document);
      var iColorType = type.GetInterfaces().First(i => i.Name == "IColor");

      foreach (var propName in new[] { "Red", "Green", "Blue", "Name", "Tint", "Shade" })
      {
        var prop = iColorType.GetProperty(propName);
        if (prop == null) continue;

        try
        {
          _ = prop.GetValue(testData);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"✗ Accessor '{type.Name}.{propName}' get failed: {ex.Message}");
          return false;
        }
      }

      foreach (var propName in new[] { "Tint", "Shade" })
      {
        var prop = iColorType.GetProperty(propName);
        if (prop?.CanWrite != true) continue;

        try
        {
          prop.SetValue(testData, 0.25);
          _ = prop.GetValue(testData);
        }
        catch (Exception ex)
        {
          Console.WriteLine($"✗ Accessor '{type.Name}.{propName}' set failed: {ex.Message}");
          return false;
        }
      }
    }

    Console.WriteLine("✓ Color accessor tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases using empty instances for all IColor implementations.
  /// </summary>
  /// <returns>True if all edge case tests pass; otherwise, false.</returns>
  private bool TestEdgeCases()
  {
    Console.WriteLine("--- Edge Cases ---");
    var jsonOptions = JsonConfig.Options;
    var document = CreateDocumentWithInitializedThemePart();
    foreach (var type in typesToTest)
    {
      var empty = Activator.CreateInstance(type);
      if (empty == null)
      {
        Console.WriteLine($"✗ Could not create empty instance of '{type.Name}'");
        return false;
      }
      AttachToDocumentContext(empty, document);

      var xml = SerializeObjectToXml(empty);
      var xmlDeserialized = DeserializeObjectFromXml(type, xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case XML deserialization failed for '{type.Name}'");
        return false;
      }
      AttachToDocumentContext(xmlDeserialized, document);

      var json = JsonSerializer.Serialize(empty, type, jsonOptions);
      var jsonDeserialized = JsonSerializer.Deserialize(json, type, jsonOptions);
      if (jsonDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case JSON deserialization failed for '{type.Name}'");
        return false;
      }
      AttachToDocumentContext(jsonDeserialized, document);
    }

    Console.WriteLine("✓ Edge case tests passed\n");
    return true;
  }

  private readonly List<Type> typesToConvert = new List<Type>
  {

    typeof(DocumentModel.Drawings.RgbColorModelHex),
    typeof(DocumentModel.Drawings.RgbColorModelPercentage),
    typeof(DocumentModel.Drawings.HslColor),
    typeof(DocumentModel.Wordprocessing.WordColor),
    typeof(DocumentModel.Wordprocessing.RgbColorHex),
  };


  private bool TestColorModelsConversion()
  {
    Console.WriteLine("--- TestColorModelsConversion ---");

    foreach (var baseType in typesToConvert)
    {
      IColor baseColor = CreateSampleColor(baseType);

      var xmlString = SerializeObjectToXml(baseColor);
      Console.WriteLine($"\nBase color model ({baseType.Name}):{xmlString}");

      foreach (var otherType in typesToConvert)
      {
        IColor otherColor = (IColor)Activator.CreateInstance(otherType)!;
        otherColor.ARGB = baseColor.ARGB;
        xmlString = SerializeObjectToXml(otherColor);
        Console.WriteLine($"\n  Color model conversion ({baseType.Name} -> {otherType.Name}):\n{xmlString}");

        if (!TestHelper.CompareTestData(typeof(IColor), baseColor, otherColor, "testColor", "otherColor", out var message))
        {
          Console.WriteLine($"✗ TestColorModelsConversion FAILED: {message}");
          return false;
        }
      }

    }

    Console.WriteLine("✓ TestColorModelsConversion passed\n");
    return true;

  }
  /// <summary>
  /// Returns all non-abstract classes in the model assembly that implement an interface named IColor.
  /// </summary>
  /// <returns>Collection of discovered IColor implementation types.</returns>
  private List<Type> GetIColorTypes()
  {
    var assembly = typeof(DocumentModel.Drawings.ColorType).Assembly;
    var colorTypes = assembly.GetTypes()
      .Where(t => !t.IsAbstract && t.GetCustomAttribute<DataContractAttribute>()!=null && t.GetInterfaces().Any(i => i.Name == "IColor"))
      .OrderBy(item => item.FullName).ToList();

    return colorTypes;
  }


  /// <summary>
  /// Creates representative sample data for each IColor implementation type.
  /// </summary>
  /// <param name="colorType">The concrete color implementation type.</param>
  /// <returns>A populated color instance.</returns>
  private IColor CreateSampleColor(Type colorType)
  {
    if (colorType == typeof(Drawings.HslColor))
      return new DocumentModel.Drawings.HslColor
      {
        Hue = new Degrees(210),
        Saturation = new Percentage("50%"),
        Luminance = new Percentage("40%"),
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };

    if (colorType == typeof(Drawings.PresetColor))
      return new DocumentModel.Drawings.PresetColor
      {
        Index = PresetColors.Red,
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    if (colorType == typeof(Drawings.RgbColorModelHex))
      return new DocumentModel.Drawings.RgbColorModelHex()
      {
        Value = (HexColor)0x336699,
        Tint = new Percentage("20%"),
        Shade = new Percentage("40%"),
      };
    if (colorType == typeof(Drawings.RgbColorModelPercentage))
      return new DocumentModel.Drawings.RgbColorModelPercentage
      {
        Red = new Percentage("20%"),
        Green = new Percentage("40%"),
        Blue = new Percentage("60%"),
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    if (colorType == typeof(Drawings.SchemeColor))
      return new DocumentModel.Drawings.SchemeColor
      {
        Index = SchemeColors.Accent3,
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    if (colorType == typeof(Drawings.SystemColor))
      return new DocumentModel.Drawings.SystemColor
      {
        Index = SystemColors.WindowText,
        LastColor = (HexColor)0x112233,
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.WordColor))
      return new DocumentModel.Wordprocessing.WordColor
      {
        Value = (HexColor)0x336699,
        //ThemeColor = DMD.SchemeColors.Text1,
        //Tint = new HexPercent("40%"),
        //Shade = new HexPercent("20%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.RgbColorHex))
      return new DocumentModel.Wordprocessing.RgbColorHex
      {
        Value = (HexColor)0x336699,
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.SchemeColor))
      return new DocumentModel.Wordprocessing.SchemeColor
      {
        Index = DMD.SchemeColors.Accent3,
        //Tint = new Percentage("10%"),
        //Shade = new Percentage("5%"),
      };
    throw new NotSupportedException($"Unsupported IColor type '{colorType.FullName}'.");
  }

  /// <summary>
  /// Tests that a Theme with a color scheme can be stored in a document and loaded back with all data intact.
  /// </summary>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  private bool StoreThemeInDocument()
  {
    Console.WriteLine("\n --- Store Theme in document ---");
    Theme testData = CreateThemeWithColorScheme();
    var testFileName = Path.Combine(_AbstractTestClass.TestFileDir, "TestThemeCreate.docx");
    using (var document = Document.Open(testFileName, FileMode.CreateNew))
    {
      document.Theme = testData;
    }

    Theme storedData;
    using (var document = Document.Open(testFileName))
    {
      var openXml = document.WordprocessingDocument!.MainDocumentPart!.ThemePart!.Theme!.OuterXml;
      //openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
      //  "http://purl.oclc.org/ooxml/wordprocessingml/main");
      var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
      Console.WriteLine(formattedOpenXml);
      var validationResult = OpenXmlSchemaValidator.ValidateXml(formattedOpenXml);
      if (!validationResult.IsValid)
      {
        Console.WriteLine("✗ Store Theme Test: OpenXml schema validation FAILED - issues found:");
        foreach (var message in validationResult.Messages)
        {
          Console.WriteLine($" {message}");
        }
        return false;
      }

      storedData = document.Theme ?? throw new InvalidOperationException("Theme not found.");
    }

    var xmlSerializer = XmlSerializationHelper.CreateXmlSerializer(typeof(Theme), out var namespaces);
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData, namespaces);
      xmlString = stringWriter.ToString();
    }
    Console.WriteLine("Theme loaded from document:\n" + xmlString);
    if (!TestHelper.CompareTestData(typeof(Theme), testData, storedData, "testData", "storedData", out var message2))
    {
      Console.WriteLine($"✗ XML test FAILED: {message2}");
      return false;
    }
    Console.WriteLine("✓ Store Theme in document passed");
    return true;

  }

  private readonly Random Random = new Random();
  private HexColor GetRandomHexColor() => (HexColor)Random.Next(0x000000, 0xFFFFFF);
  //private DXW.ThemeColorValues GetRandomThemeColor() => (DXW.ThemeColorValues)Random.Next(1, Enum.GetValues(typeof(DXW.ThemeColorValues)).Length);

  /// <summary>
  /// Changes colors of two specific run texts in the specified document.
  /// First copies the document to a temporary file to avoid modifying the original.
  /// Temporary file has a name like "Colors test updated.docx" in the same directory as the original.
  /// Finds run text "RED" and changes it to blue. Finds run text "ACCENT1" and changes it to theme Accent2.
  /// </summary>
  /// <param name="filePath">Path to the .docx/.zip OpenXml package.</param>
  /// <returns>True if both target runs were found and updated; otherwise, false.</returns>
  private bool ChangeColorsInDocument(string filePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\Colors test.docx")
  {
    Console.WriteLine("\n--- Change Colors in Document ---");

    if (!File.Exists(filePath))
    {
      Console.WriteLine($"✗ File not found: {filePath}");
      return false;
    }
    var newFilePath = Path.Combine(Path.GetDirectoryName(filePath) ?? ".", Path.GetFileNameWithoutExtension(filePath) + " updated" + Path.GetExtension(filePath));

    System.IO.File.Copy(filePath, newFilePath, true);
    var document = Document.Open(newFilePath);
    var body = document.Body;

    var redUpdated = false;
    var accentUpdated = false;

    foreach (var paragraph in body.Paragraphs)
    {
      //Debug.WriteLine($"Enumerated paragraph {paragraph.ParagraphId}");
      //int runIndex = 0;
      foreach (var run in paragraph.Runs)
      {
        //Debug.WriteLine($"  Enumerated run[{runIndex}] Items count={run.Items.Count}");
        //runIndex++;
        foreach (var item in run.Items)
        {
          //string? text = null;
          //if (item is RunText runText)
          //  text = $"\"{runText.Text}\"";
          //Debug.WriteLine($"    Enumerated run item {item.GetType()} {text}");

        }
        if (!redUpdated && run.Text == "RED")
        {
          run.Text = "BLUE";
          var runProperties = run.RunProperties;
          if (runProperties == null)
            throw new ApplicationException("Run properties not found.");
          var color = runProperties.Color;
          if (color == null)
            throw new ApplicationException("Color not found.");
          if (color.Value != "FF0000")
            throw new ApplicationException($"Unexpected color value for RED run: {color.Value}");
          color.Value = "0000FF";
          color.ThemeColor = null;
          color.Tint = null;
          color.Shade = null;
          redUpdated = true;
        }
        else if (!accentUpdated && run.Text == "ACCENT1")
        {
          run.Text = "ACCENT2";
          var runProperties = run.RunProperties;
          if (runProperties == null)
            throw new ApplicationException("Run properties not found.");
          var color = runProperties.Color;
          if (color == null)
            throw new ApplicationException("Color not found.");
          if (color.ThemeColor != DMD.SchemeColors.Accent1)
            throw new ApplicationException($"Unexpected color value for ACCENT1 run: {color.ThemeColor}");

          color.Value = null;
          color.ThemeColor = DMD.SchemeColors.Accent2;
          color.Tint = null;
          color.Shade = null;
          accentUpdated = true;
        }

        if (redUpdated && accentUpdated)
          break;
      }
    }

    document.Save();

    if (!redUpdated)
      Console.WriteLine("✗ Run with text 'RED' not found.");
    if (!accentUpdated)
      Console.WriteLine("✗ Run with text 'ACCENT1' not found.");

    var result = redUpdated && accentUpdated;
    if (result)
      Console.WriteLine("✓  Change Colors in Document passed");

    return result;
  }

}
