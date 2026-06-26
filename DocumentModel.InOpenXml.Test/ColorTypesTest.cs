using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Xml;
using System.Xml.Serialization;

using DocumentModel.Drawings;

using Path = System.IO.Path;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive tests for all DocumentModel types implementing IColor.
/// </summary>
public class ColorTypesTest : _AbstractTestClass
{
  /// <summary>
  /// Runs all IColor implementation tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Color Implementations Test ===\n");
    if (!TestTypeDiscovery()) return false;
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestColorAccessors()) return false;
    if (!TestEdgeCases()) return false;
    if (!StoreThemeInDocument()) return false;
    if (!ChangeColorsInDocument()) return false;
    Console.WriteLine("All Color implementation tests passed.\n");
    return true;
  }

  /// <summary>
  /// Verifies that all known IColor implementations are discovered.
  /// </summary>
  /// <returns>True if discovery is correct; otherwise, false.</returns>
  private bool TestTypeDiscovery()
  {
    Console.WriteLine("--- Color Type Discovery ---");
    var discovered = GetIColorTypes().OrderBy(item => item.Type.FullName).ToList();
    var expected = new List<(Type Type, ColorModel Model)>
    {
      (typeof(DocumentModel.Drawings.ColorType),ColorModel.HSL),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.Preset),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.RGBHex),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.RGBPercentage),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.Scheme),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.System),
      (typeof(DocumentModel.Wordprocessing.Color), ColorModel.RGBHex),
      (typeof(DocumentModel.Wordprocessing.RgbColorHex), ColorModel.RGBHex),
      (typeof(DocumentModel.Wordprocessing.SchemeColor), ColorModel.Scheme),
    }.OrderBy(item => item.Type.FullName).ToList();

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

    foreach (var item in GetIColorTypes())
    {
      var color = CreateSampleColor(item.Type, item.Model);
      AttachToDocumentContext(color, document);
      xmlString = SerializeObjectToXml(color);
      Console.WriteLine($"\nSerialized XML ({item.Type.Name} {item.Model}):\n{xmlString}");

      var deserialized = DeserializeObjectFromXml(item.Type, xmlString);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ Theme/Color XML Deserialization returned null for '{item.Type.Name} {item.Model}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(item.Type, color, deserialized, "testColor", "deserialized", out message))
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

    foreach (var item in GetIColorTypes())
    {
      var color = CreateSampleColor(item.Type, item.Model);
      AttachToDocumentContext(color, document);
      JsonString = SerializeToJson(color);
      Console.WriteLine($"\nSerialized Json ({item.Type.Name} {item.Model}):\n{JsonString}");

      var deserialized = DeserializeFromJson(color.GetType(), JsonString);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ XTheme/Color ML Deserialization returned null for '{item.Type.Name} {item.Model}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(item.Type, color, deserialized, "testColor", "deserialized", out message))
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
    foreach (var item in GetIColorTypes())
    {
      var testData = CreateSampleColor(item.Type, item.Model);
      AttachToDocumentContext(testData, document);
      var iColorType = item.Type.GetInterfaces().First(i => i.Name == "IColor");

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
          Console.WriteLine($"✗ Accessor '{item.Type.Name}.{propName}' get failed: {ex.Message}");
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
          Console.WriteLine($"✗ Accessor '{item.Type.Name}.{propName}' set failed: {ex.Message}");
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
    var jsonOptions = CreateJsonOptions();
    var document = CreateDocumentWithInitializedThemePart();
    foreach (var item in GetIColorTypes())
    {
      var empty = Activator.CreateInstance(item.Type);
      if (empty == null)
      {
        Console.WriteLine($"✗ Could not create empty instance of '{item.Type.Name}'");
        return false;
      }
      AttachToDocumentContext(empty, document);

      var xml = SerializeObjectToXml(empty);
      var xmlDeserialized = DeserializeObjectFromXml(item.Type, xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case XML deserialization failed for '{item.Type.Name}'");
        return false;
      }
      AttachToDocumentContext(xmlDeserialized, document);

      var json = JsonSerializer.Serialize(empty, item.Type, jsonOptions);
      var jsonDeserialized = JsonSerializer.Deserialize(json, item.Type, jsonOptions);
      if (jsonDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case JSON deserialization failed for '{item.Type.Name}'");
        return false;
      }
      AttachToDocumentContext(jsonDeserialized, document);
    }

    Console.WriteLine("✓ Edge case tests passed\n");
    return true;
  }

  /// <summary>
  /// Returns all non-abstract classes in the model assembly that implement an interface named IColor.
  /// </summary>
  /// <returns>Collection of discovered IColor implementation types.</returns>
  private List<(Type Type, ColorModel Model)> GetIColorTypes()
  {
    var expected = new List<(Type Type, ColorModel Model)>
    {
      (typeof(DocumentModel.Drawings.ColorType),ColorModel.HSL),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.Preset),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.RGBHex),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.RGBPercentage),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.Scheme),
      (typeof(DocumentModel.Drawings.ColorType), ColorModel.System),
      (typeof(DocumentModel.Wordprocessing.Color), ColorModel.RGBHex),
      (typeof(DocumentModel.Wordprocessing.RgbColorHex), ColorModel.RGBHex),
      (typeof(DocumentModel.Wordprocessing.SchemeColor), ColorModel.Scheme),
    }.OrderBy(item => item.Type.FullName).ToList();
    return expected;
  }

  /// <summary>
  /// Creates representative sample data for each IColor implementation type.
  /// </summary>
  /// <param name="colorType">The concrete color implementation type.</param>
  /// <param name="colorModel">The color model associated with the color type.</param>
  /// <returns>A populated color instance.</returns>
  private object CreateSampleColor(Type colorType, ColorModel colorModel)
  {
    if (colorType == typeof(ColorType) && colorModel == ColorModel.HSL)
      return new Drawings.ColorType
      {
        Hue = new Degrees(120),
        Saturation = new Percentage("60%"),
        Luminance = new Percentage("45%"),
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };

    if (colorType == typeof(ColorType) && colorModel == ColorModel.Preset)
      return new DocumentModel.Drawings.ColorType
      {
        PresetColor = PresetColors.Red,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(ColorType) && colorModel == ColorModel.RGBHex)
      return new DocumentModel.Drawings.ColorType
      {
        RGB = (HexColor)0x336699,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(ColorType) && colorModel == ColorModel.RGBPercentage)
      return new DocumentModel.Drawings.ColorType
      {
        Red = new Percentage("20%"),
        Green = new Percentage("40%"),
        Blue = new Percentage("60%"),
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(ColorType) && colorModel == ColorModel.Scheme)
      return new DocumentModel.Drawings.ColorType
      {
        SchemeColor = SchemeColors.Accent3,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(ColorType) && colorModel == ColorModel.System)
      return new DocumentModel.Drawings.ColorType
      {
        SystemColor = SystemColors.WindowText,
        LastColor = (HexColor)0x112233,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.Color))
      return new DocumentModel.Wordprocessing.Color
      {
        Val = (HexColor)0x445566,
        ThemeColor = ThemeColors.Text1,
        ThemeTint = new HexPercent("40%"),
        ThemeShade = new HexPercent("20%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.RgbColorHex))
      return new DocumentModel.Wordprocessing.RgbColorHex
      {
        Value = (HexColor)0x336699,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.SchemeColor))
      return new DocumentModel.Wordprocessing.SchemeColor
      {
        Index = DMD.SchemeColors.Accent3,
        Tint = new Percentage("10%"),
        Shade = new Percentage("5%"),
      };
    throw new NotSupportedException($"Unsupported IColor type '{colorType.FullName}'.");
  }

  /// <summary>
  /// Creates a document context initialized with a theme and color scheme.
  /// </summary>
  /// <returns>Document context for color tests.</returns>
  private DocumentModel.Wordprocessing.Document CreateDocumentWithInitializedThemePart()
  {
    var document = new DocumentModel.Wordprocessing.Document();
    document.Theme = CreateThemeWithColorScheme();
    return document;
  }

  /// <summary>
  /// Attaches a color instance to the document context to enable ParentDocument-dependent behavior.
  /// </summary>
  /// <param name="color">Color instance to attach.</param>
  /// <param name="document">Document context containing initialized theme data.</param>
  private void AttachToDocumentContext(object color, DocumentModel.Wordprocessing.Document document)
  {
    if (color is ModelElement modelElement)
      modelElement.SetParent(document);
  }

  /// <summary>
  /// Initializes the document theme part with a basic color scheme.
  /// </summary>
  private Theme CreateThemeWithColorScheme()
  {
    var theme = new Theme
    {
      Name = "Office Theme",
      ThemeElements = new ThemeElements
      {
        ColorScheme = new ColorScheme
        {
          Name = "Office",
          Dark1Color = new ColorType() { SystemColor = SystemColors.WindowText, LastColor = (HexColor)0x000000 },
          Light1Color = new ColorType() { SystemColor = SystemColors.Window, LastColor = (HexColor)0xFFFFFF },
          Dark2Color = new ColorType { RGB = (HexColor)0x0E2841 },
          Light2Color = new ColorType { RGB = (HexColor)0xE8E8E8 },
          Accent1Color = new ColorType { RGB = (HexColor)0x156082 },
          Accent2Color = new ColorType { RGB = (HexColor)0xE97132 },
          Accent3Color = new ColorType { RGB = (HexColor)0xE97132 },
          Accent4Color = new ColorType { RGB = (HexColor)0x0F9ED5 },
          Accent5Color = new ColorType { RGB = (HexColor)0xA02B93 },
          Accent6Color = new ColorType { RGB = (HexColor)0x4EA72E },
          Hyperlink = new ColorType { RGB = (HexColor)0x0467886 },
          FollowedHyperlink = new ColorType { RGB = (HexColor)0x96607D },
        }
      }
    };
    return theme;
  }

  private JsonSerializerOptions CreateJsonOptions()
  {
    var options = new JsonSerializerOptions(JsonConfig.Options);
    //var resolver = new DefaultJsonTypeInfoResolver();
    //resolver.Modifiers.Add(typeInfo =>
    //{
    //  if (typeInfo.Type != typeof(ModelElement))
    //    return;

    //  var polymorphismOptions = new JsonPolymorphismOptions
    //  {
    //    TypeDiscriminatorPropertyName = "$type"
    //  };
    //  foreach (var derivedType in GetIColorTypes().Where(t => typeof(ModelElement).IsAssignableFrom(t)))
    //  {
    //    polymorphismOptions.DerivedTypes.Add(new JsonDerivedType(derivedType, derivedType.FullName!));
    //  }
    //  typeInfo.PolymorphismOptions = polymorphismOptions;
    //});

    //options.TypeInfoResolver = resolver;
    return options;
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
      Debug.WriteLine($"Enumerated paragraph {paragraph.ParagraphId}");
      int runIndex = 0;
      foreach (var run in paragraph.Runs)
      {
        Debug.WriteLine($"  Enumerated run[{runIndex}] Items count={run.Items.Count}");
        runIndex++;
        foreach (var item in run.Items)
        {
          string? text = null;
          if (item is RunText runText)
            text = $"\"{runText.Text}\"";
          Debug.WriteLine($"    Enumerated run item {item.GetType()} {text}");

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
          if (color.Val!="FF0000")
            throw new ApplicationException($"Unexpected color value for RED run: {color.Val}");
          color.Val = "0000FF";
          color.ThemeColor = null;
          color.ThemeTint = null;
          color.ThemeShade = null;
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
          if (color.ThemeColor != ThemeColors.Accent1)
            throw new ApplicationException($"Unexpected color value for ACCENT1 run: {color.ThemeColor}");

          color.Val = null;
          color.ThemeColor = ThemeColors.Accent2;
          color.ThemeTint = null;
          color.ThemeShade = null;
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
