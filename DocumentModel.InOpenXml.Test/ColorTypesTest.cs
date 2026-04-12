using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

using DocumentModel.Drawings;

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
  public static bool Run()
  {
    Console.WriteLine("=== IColor Implementations Test ===\n");
    if (!TestTypeDiscovery()) return false;
    if (!TestXmlSerialization()) return false;
    if (!TestJsonSerialization()) return false;
    if (!TestIColorAccessors()) return false;
    if (!TestEdgeCases()) return false;
    if (!StoreThemeInDocument()) return false;
    if (!ChangeTwoWordColorsInDocument()) return false;
    Console.WriteLine("All IColor implementation tests passed.\n");
    return true;
  }

  /// <summary>
  /// Verifies that all known IColor implementations are discovered.
  /// </summary>
  /// <returns>True if discovery is correct; otherwise, false.</returns>
  static bool TestTypeDiscovery()
  {
    Console.WriteLine("--- IColor Type Discovery ---");
    var discovered = GetIColorTypes().OrderBy(t => t.FullName).ToList();
    var expected = new List<Type>
    {
      typeof(DocumentModel.Drawings.HslColor),
      typeof(DocumentModel.Drawings.PresetColor),
      typeof(DocumentModel.Drawings.RgbColorModelHex),
      typeof(DocumentModel.Drawings.RgbColorModelPercentage),
      typeof(DocumentModel.Drawings.SchemeColor),
      typeof(DocumentModel.Drawings.SystemColor),
      typeof(DocumentModel.Wordprocessing.Color),
      typeof(DocumentModel.Wordprocessing.Drawings.RgbColorModelHex),
      typeof(DocumentModel.Wordprocessing.Drawings.SchemeColor),
    }.OrderBy(t => t.FullName).ToList();

    if (!discovered.SequenceEqual(expected))

    {
      Console.WriteLine("✗ IColor type discovery FAILED");
      Console.WriteLine("Discovered:");
      foreach (var item in discovered) Console.WriteLine($"  {item}");
      Console.WriteLine("Expected:");
      foreach (var item in expected) Console.WriteLine($"  {item}");
      return false;
    }

    Console.WriteLine("✓ IColor type discovery passed\n");
    return true;
  }

  /// <summary>
  /// Tests XML serialization and deserialization for all IColor implementations.
  /// </summary>
  /// <returns>True if all XML tests pass; otherwise, false.</returns>
  static bool TestXmlSerialization()
  {
    Console.WriteLine("--- XML Serialization ---");
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
    if (!TestHelper.CompareTestData(typeof(Theme), theme, deserializedTheme, out var propName1))
    {
      Console.WriteLine($"✗ XML test FAILED for '{theme.GetType().Name}' - mismatch in '{propName1}'");
      return false;
    }

    foreach (var colorType in GetIColorTypes())
    {
      var testData = CreateSampleColor(colorType);
      AttachToDocumentContext(testData, document);
      xmlString = SerializeObjectToXml(testData);
      Console.WriteLine($"\nSerialized XML ({colorType.Name}):\n{xmlString}");

      var deserialized = DeserializeObjectFromXml(colorType, xmlString);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ XML Deserialization returned null for '{colorType.Name}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(colorType, testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ XML test FAILED for '{colorType.Name}' - mismatch in '{propName}'");
        return false;
      }
    }

    Console.WriteLine("✓ XML serialization tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests JSON serialization and deserialization for all IColor implementations.
  /// </summary>
  /// <returns>True if all JSON tests pass; otherwise, false.</returns>
  static bool TestJsonSerialization()
  {
    Console.WriteLine("--- JSON Serialization ---");
    var document = CreateDocumentWithInitializedThemePart();
    var theme = document.Theme!;
    var jsonString = JsonSerializer.Serialize(theme, typeof(Theme), JsonConfig.Options);
    Console.WriteLine($"\nSerialized JSON (theme):\n{jsonString}");
    var deserializedTheme = JsonSerializer.Deserialize(jsonString, typeof(Theme), JsonConfig.Options);
    if (deserializedTheme == null)
    {
      Console.WriteLine($"✗ JSON theme deserialization returned null for '{theme.GetType().Name}'");
      return false;
    }
    if (!TestHelper.CompareTestData(typeof(Theme), theme, deserializedTheme, out var propName1))
    {
      Console.WriteLine($"✗ JSON test FAILED for '{theme.GetType().Name}' - mismatch in '{propName1}'");
      return false;
    }

    foreach (var colorType in GetIColorTypes())
    {
      var testData = CreateSampleColor(colorType);
      AttachToDocumentContext(testData, document);
      jsonString = JsonSerializer.Serialize(testData, colorType, JsonConfig.Options);
      Console.WriteLine($"\nSerialized JSON ({colorType.Name}):\n{jsonString}");

      var deserialized = JsonSerializer.Deserialize(jsonString, colorType, JsonConfig.Options);
      if (deserialized == null)
      {
        Console.WriteLine($"✗ JSON Deserialization returned null for '{colorType.Name}'");
        return false;
      }
      AttachToDocumentContext(deserialized, document);

      if (!TestHelper.CompareTestData(colorType, testData, deserialized, out var propName))
      {
        Console.WriteLine($"✗ JSON test FAILED for '{colorType.Name}' - mismatch in '{propName}'");
        return false;
      }
    }

    Console.WriteLine("✓ JSON serialization tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests common IColor accessors for all implementations.
  /// </summary>
  /// <returns>True if all accessor tests pass; otherwise, false.</returns>
  static bool TestIColorAccessors()
  {
    Console.WriteLine("--- IColor Accessors ---");
    var document = CreateDocumentWithInitializedThemePart();
    foreach (var colorType in GetIColorTypes())
    {
      var testData = CreateSampleColor(colorType);
      AttachToDocumentContext(testData, document);
      var iColorType = colorType.GetInterfaces().First(i => i.Name == "IColor");

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
          Console.WriteLine($"✗ Accessor '{colorType.Name}.{propName}' get failed: {ex.Message}");
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
          Console.WriteLine($"✗ Accessor '{colorType.Name}.{propName}' set failed: {ex.Message}");
          return false;
        }
      }
    }

    Console.WriteLine("✓ IColor accessor tests passed\n");
    return true;
  }

  /// <summary>
  /// Tests edge cases using empty instances for all IColor implementations.
  /// </summary>
  /// <returns>True if all edge case tests pass; otherwise, false.</returns>
  static bool TestEdgeCases()
  {
    Console.WriteLine("--- Edge Cases ---");
    var document = CreateDocumentWithInitializedThemePart();
    foreach (var colorType in GetIColorTypes())
    {
      var empty = Activator.CreateInstance(colorType);
      if (empty == null)
      {
        Console.WriteLine($"✗ Could not create empty instance of '{colorType.Name}'");
        return false;
      }
      AttachToDocumentContext(empty, document);

      var xml = SerializeObjectToXml(empty);
      var xmlDeserialized = DeserializeObjectFromXml(colorType, xml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case XML deserialization failed for '{colorType.Name}'");
        return false;
      }
      AttachToDocumentContext(xmlDeserialized, document);

      var json = JsonSerializer.Serialize(empty, colorType, JsonConfig.Options);
      var jsonDeserialized = JsonSerializer.Deserialize(json, colorType, JsonConfig.Options);
      if (jsonDeserialized == null)
      {
        Console.WriteLine($"✗ Edge case JSON deserialization failed for '{colorType.Name}'");
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
  static List<Type> GetIColorTypes()
  {
    return typeof(RgbColorModelHex).Assembly.GetTypes()
      .Where(t => t.IsClass && !t.IsAbstract)
      .Where(t => t.Namespace?.StartsWith("DocumentModel.", StringComparison.Ordinal) == true)
      .Where(t => t.GetInterfaces().Any(i => i.Name == "IColor"))
      .OrderBy(t => t.FullName)
      .ToList();
  }

  /// <summary>
  /// Creates representative sample data for each IColor implementation type.
  /// </summary>
  /// <param name="colorType">The concrete color implementation type.</param>
  /// <returns>A populated color instance.</returns>
  static object CreateSampleColor(Type colorType)
  {
    if (colorType == typeof(DocumentModel.Drawings.HslColor))
      return new HslColor
      {
        HueValue = new Degrees(120),
        SatValue = new Percentage(60),
        LumValue = new Percentage(45),
        Tint = new Percentage(10),
        Shade = new Percentage(5),
      };

    if (colorType == typeof(DocumentModel.Drawings.PresetColor))
      return new DocumentModel.Drawings.PresetColor { Val = PresetColors.Red, Tint = new Percentage(10), Shade = new Percentage(5), };
    if (colorType == typeof(DocumentModel.Drawings.RgbColorModelHex))
      return new DocumentModel.Drawings.RgbColorModelHex { Val = (HexColor)0x336699, Tint = new Percentage(10), Shade = new Percentage(5), };
    if (colorType == typeof(DocumentModel.Drawings.RgbColorModelPercentage))
      return new DocumentModel.Drawings.RgbColorModelPercentage
      {
        Red = new Percentage(20),
        Green = new Percentage(40),
        Blue = new Percentage(60),
        Tint = new Percentage(10),
        Shade = new Percentage(5),
      };
    if (colorType == typeof(DocumentModel.Drawings.SchemeColor))
      return new DocumentModel.Drawings.SchemeColor { Val = SchemeColors.Accent3, Tint = new Percentage(10), Shade = new Percentage(5), };
    if (colorType == typeof(DocumentModel.Drawings.SystemColor))
      return new DocumentModel.Drawings.SystemColor
      {
        Val = SystemColors.WindowText,
        LastColor = (HexColor)0x112233,
        Tint = new Percentage(10),
        Shade = new Percentage(5),
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.Color))
      return new DocumentModel.Wordprocessing.Color
      {
        Val = (HexColor)0x445566,
        ThemeColor = ThemeColors.Text1,
        ThemeTint = 40,
        ThemeShade = 20,
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.Drawings.RgbColorModelHex))
      return new DocumentModel.Wordprocessing.Drawings.RgbColorModelHex
      {
        Val = (HexColor)0x336699,
        Tint = 10000,
        Shade = 5000,
      };
    if (colorType == typeof(DocumentModel.Wordprocessing.Drawings.SchemeColor))
      return new DocumentModel.Wordprocessing.Drawings.SchemeColor
      {
        Val = SchemeColors.Accent3,
        Tint = 10000,
        Shade = 5000,
      };
    throw new NotSupportedException($"Unsupported IColor type '{colorType.FullName}'.");
  }

  /// <summary>
  /// Creates a document context initialized with a theme and color scheme.
  /// </summary>
  /// <returns>Document context for color tests.</returns>
  static DocumentModel.Wordprocessing.Document CreateDocumentWithInitializedThemePart()
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
  static void AttachToDocumentContext(object color, DocumentModel.Wordprocessing.Document document)
  {
    if (color is ModelElement modelElement)
      modelElement.SetParent(document);
  }

  /// <summary>
  /// Initializes the document theme part with a basic color scheme.
  /// </summary>
  /// <param name="document">Target document whose theme should be initialized.</param>
  static Theme CreateThemeWithColorScheme()
  {
    var theme = new Theme
    {
      Name = "ColorTypesTest Theme",
      ThemeId = "ColorTypesTestTheme",
      ThemeElements = new ThemeElements
      {
        ColorScheme = new ColorScheme
        {
          Name = "ColorTypesTest Color Scheme",
          Dark1Color = new RgbColorModelHex { Val = (HexColor)0x000000 },
          Light1Color = new RgbColorModelHex { Val = (HexColor)0xFFFFFF },
          Dark2Color = new RgbColorModelPercentage { Red = 0.5, Green = 0.5, Blue = 0.5 },
          Light2Color = new HslColor { HueValue = new Degrees(60), LumValue = new Percentage(45), SatValue = new Percentage(60) },
          Accent1Color = new RgbColorModelHex { Val = (HexColor)0x4472C4 },
          Accent2Color = new RgbColorModelHex { Val = (HexColor)0xED7D31 },
          Accent3Color = new RgbColorModelHex { Val = (HexColor)0xA5A5A5 },
          Accent4Color = new RgbColorModelHex { Val = (HexColor)0xFFC000 },
          Accent5Color = new RgbColorModelHex { Val = (HexColor)0x5B9BD5 },
          Accent6Color = new RgbColorModelHex { Val = (HexColor)0x70AD47 },
          Hyperlink = new RgbColorModelHex { Val = (HexColor)0x0563C1 },
          FollowedHyperlinkColor = new RgbColorModelHex { Val = (HexColor)0x954F72 },
        }
      }
    };
    return theme;
  }

  /// <summary>
  /// Tests that a Theme with a color scheme can be stored in a document and loaded back with all data intact.
  /// </summary>
  /// <returns></returns>
  /// <exception cref="InvalidOperationException"></exception>
  public static bool StoreThemeInDocument()
  {
    Console.WriteLine("--- Store Theme in document ---");
    {
      Theme testData = CreateThemeWithColorScheme();
      using (var document = new Document(TestFileName, FileMode.CreateNew))
      {
        document.Theme = testData;
      }

      Theme storedData;
      using (var document = new Document(TestFileName))
      {
        var openXml = document.WordprocessingDocument!.MainDocumentPart!.ThemePart!.Theme!.OuterXml;
        //openXml = openXml.Replace("http://schemas.openxmlformats.org/wordprocessingml/2006/main",
        //  "http://purl.oclc.org/ooxml/wordprocessingml/main");
        var formattedOpenXml = openXml.FormatXmlWithLineNumbers();
        Console.WriteLine(formattedOpenXml);
        storedData = document.Theme ?? throw new InvalidOperationException("Theme not found.");
      }

      var xmlSerializer = new XmlSerializer(typeof(Theme));
      string xmlString;
      using (var stringWriter = new StringWriter())
      using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
      {
        xmlSerializer.Serialize(xmlWriter, storedData);
        xmlString = stringWriter.ToString();
      }
      Console.WriteLine("Theme loaded from document:\n" + xmlString);
      if (!TestHelper.CompareTestData(typeof(Theme), testData, storedData, out var propName1))
      {
        Console.WriteLine($"✗ XML test FAILED for '{storedData.GetType().Name}' - mismatch in '{propName1}'");
        return false;
      }
      return true;
    }

  }

  private static readonly Random Random = new Random();
  private static HexColor GetRandomHexColor() => (HexColor)Random.Next(0x000000, 0xFFFFFF);
  //private static DXW.ThemeColorValues GetRandomThemeColor() => (DXW.ThemeColorValues)Random.Next(1, Enum.GetValues(typeof(DXW.ThemeColorValues)).Length);

  /// <summary>
  /// Changes colors of two specific run texts in the specified document package.
  /// Finds run text "RED" and changes it to blue. Finds run text "ACCENT1" and changes it to theme Accent2.
  /// </summary>
  /// <param name="filePath">Path to the .docx/.zip OpenXml package.</param>
  /// <returns>True if both target runs were found and updated; otherwise, false.</returns>
  public static bool ChangeTwoWordColorsInDocument(string filePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\Colors test2.zip")
  {
    Console.WriteLine("--- Two Word Colors in Document ---");

    if (!File.Exists(filePath))
    {
      Console.WriteLine($"✗ File not found: {filePath}");
      return false;
    }

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(filePath, true);
    var body = wordDoc.MainDocumentPart?.Document?.Body;
    if (body == null)
    {
      Console.WriteLine("✗ Main document body not found.");
      return false;
    }

    var redUpdated = false;
    var accentUpdated = false;

    foreach (var run in body.Descendants<DocumentFormat.OpenXml.Wordprocessing.Run>())
    {
      var runText = string.Concat(run.Elements<DocumentFormat.OpenXml.Wordprocessing.Text>().Select(t => t.Text));
      if (string.IsNullOrEmpty(runText))
        continue;

      if (!redUpdated && runText == "RED")
      {
        var runProperties = run.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>() ?? run.PrependChild(new DocumentFormat.OpenXml.Wordprocessing.RunProperties());
        var color = runProperties.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>() ?? runProperties.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Color());
        color.Val = GetRandomHexColor().ToString();
        color.ThemeColor = null;
        color.ThemeTint = null;
        color.ThemeShade = null;
        redUpdated = true;
      }
      else if (!accentUpdated && runText == "ACCENT1")
      {
        var runProperties = run.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunProperties>() ?? run.PrependChild(new DocumentFormat.OpenXml.Wordprocessing.RunProperties());
        var color = runProperties.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Color>() ?? runProperties.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Color());
        color.Val = null;
        color.ThemeColor = DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent2;
        accentUpdated = true;
      }

      if (redUpdated && accentUpdated)
        break;
    }

    wordDoc.MainDocumentPart?.Document?.Save();

    if (!redUpdated)
      Console.WriteLine("✗ Run with text 'RED' not found.");
    if (!accentUpdated)
      Console.WriteLine("✗ Run with text 'ACCENT1' not found.");

    var result = redUpdated && accentUpdated;
    if (result)
      Console.WriteLine("--- Two Word Colors in Document passed ---");

    return result;
  }

  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <returns>Serialized XML text.</returns>
  static string SerializeObjectToXml(object data)
  {
    var rootType = data.GetType();

    var ns = new XmlSerializerNamespaces();
    ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    ns.Add("d", "DocumentModel.Drawings");
    ns.Add("wd", "DocumentModel.Wordprocessing.Drawings");


    var xmlSerializer = new XmlSerializer(rootType);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, ns);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  static object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = new XmlSerializer(dataType);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }
}
