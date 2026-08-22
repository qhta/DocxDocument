using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

using DocumentModel.Drawings;

using Path = System.IO.Path;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive tests for all DocumentModel types implementing IColor.
/// </summary>
public class ThemeTest : _AbstractTestClass
{

  /// <summary>
  /// Runs all IColor implementation tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Document Theme Test ===\n");
    if (!StoreThemeInDocument()) return false;
    Console.WriteLine("All Document Theme tests passed.\n");
    return true;
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

    var xmlSerializer = XmlSerializationHelper.CreateXmlSerializer(typeof(Theme));
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, storedData, XmlSerializationHelper.Namespaces);
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


  /// <summary>
  /// Creates a Theme with a basic content.
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
          Dark1Color = new  SystemColor { Index = SystemColors.WindowText, LastColor = (HexColor)0x000000 },
          Light1Color = new  SystemColor { Index = SystemColors.Window, LastColor = (HexColor)0xFFFFFF },
          Dark2Color = new RgbColorModelHex { Value = (HexColor)0x0E2841 },
          Light2Color = new RgbColorModelHex { Value = (HexColor)0xE8E8E8 },
          Accent1Color = new RgbColorModelHex { Value = (HexColor)0x156082 },
          Accent2Color = new RgbColorModelHex { Value = (HexColor)0xE97132 },
          Accent3Color = new RgbColorModelHex { Value = (HexColor)0xE97132 },
          Accent4Color = new RgbColorModelHex { Value = (HexColor)0x0F9ED5 },
          Accent5Color = new RgbColorModelHex { Value = (HexColor)0xA02B93 },
          Accent6Color = new RgbColorModelHex { Value = (HexColor)0x4EA72E },
          Hyperlink = new RgbColorModelHex { Value = (HexColor)0x0467886 },
          FollowedHyperlink = new RgbColorModelHex { Value = (HexColor)0x96607D },
        },
        FontScheme = new FontScheme
        {
          Name = "Office",
          MajorFont = new MajorFont
          {
            LatinFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xEE },
            EastAsianFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0x80 },
            ComplexScriptFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xB1 },
            SupplementalFonts =
            [
              new SupplementalFont { Script = "Jpan", Typeface = "游ゴシック Light" },
              new SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" },
              new SupplementalFont { Script = "Hans", Typeface = "等线 Light" },
              new SupplementalFont { Script = "Hant", Typeface = "新細明體" },
              new SupplementalFont { Script = "Arab", Typeface = "Times New Roman" },
              new SupplementalFont { Script = "Hebr", Typeface = "Times New Roman" },
              new SupplementalFont { Script = "Thai", Typeface = "Angsana New" },
              new SupplementalFont { Script = "Ethi", Typeface = "Nyala" },
              new SupplementalFont { Script = "Beng", Typeface = "Vrinda" },
              new SupplementalFont { Script = "Gujr", Typeface = "Shruti" },
              new SupplementalFont { Script = "Khmr", Typeface = "MoolBoran" },
              new SupplementalFont { Script = "Knda", Typeface = "Tunga" },
              new SupplementalFont { Script = "Guru", Typeface = "Raavi" },
              new SupplementalFont { Script = "Cans", Typeface = "Euphemia" },
              new SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" },
              new SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" },
              new SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" },
              new SupplementalFont { Script = "Thaa", Typeface = "MV Boli" },
              new SupplementalFont { Script = "Deva", Typeface = "Mangal" },
              new SupplementalFont { Script = "Telu", Typeface = "Gautami" },
              new SupplementalFont { Script = "Taml", Typeface = "Latha" },
              new SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Orya", Typeface = "Kalinga" },
              new SupplementalFont { Script = "Mlym", Typeface = "Kartika" },
              new SupplementalFont { Script = "Laoo", Typeface = "DokChampa" },
              new SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" },
              new SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" },
              new SupplementalFont { Script = "Viet", Typeface = "Times New Roman" },
              new SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" },
              new SupplementalFont { Script = "Geor", Typeface = "Sylfaen" },
              new SupplementalFont { Script = "Armn", Typeface = "Arial" },
              new SupplementalFont { Script = "Bugi", Typeface = "Leelawadee UI" },
              new SupplementalFont { Script = "Bopo", Typeface = "Microsoft JhengHei" },
              new SupplementalFont { Script = "Java", Typeface = "Javanese Text" },
              new SupplementalFont { Script = "Lisu", Typeface = "Segoe UI" },
              new SupplementalFont { Script = "Mymr", Typeface = "Myanmar Text" },
              new SupplementalFont { Script = "Nkoo", Typeface = "Ebrima" },
              new SupplementalFont { Script = "Olck", Typeface = "Nirmala UI" },
              new SupplementalFont { Script = "Osma", Typeface = "Ebrima" },
              new SupplementalFont { Script = "Phag", Typeface = "Phagspa" },
              new SupplementalFont { Script = "Syrn", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Syrj", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Syre", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Sora", Typeface = "Nirmala UI" },
              new SupplementalFont { Script = "Tale", Typeface = "Microsoft Tai Le" },
              new SupplementalFont { Script = "Talu", Typeface = "Microsoft New Tai Lue" },
              new SupplementalFont { Script = "Tfng", Typeface = "Ebrima" },
            ]
          },
          MinorFont = new MinorFont
          {
            LatinFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xEE },
            EastAsianFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0x80 },
            ComplexScriptFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xB1 },
            SupplementalFonts =
            [
              new SupplementalFont { Script = "Jpan", Typeface = "游明朝" },
              new SupplementalFont { Script = "Hang", Typeface = "맑은 고딕" },
              new SupplementalFont { Script = "Hans", Typeface = "等线" },
              new SupplementalFont { Script = "Hant", Typeface = "新細明體" },
              new SupplementalFont { Script = "Arab", Typeface = "Arial" },
              new SupplementalFont { Script = "Hebr", Typeface = "Arial" },
              new SupplementalFont { Script = "Thai", Typeface = "Cordia New" },
              new SupplementalFont { Script = "Ethi", Typeface = "Nyala" },
              new SupplementalFont { Script = "Beng", Typeface = "Vrinda" },
              new SupplementalFont { Script = "Gujr", Typeface = "Shruti" },
              new SupplementalFont { Script = "Khmr", Typeface = "DaunPenh" },
              new SupplementalFont { Script = "Knda", Typeface = "Tunga" },
              new SupplementalFont { Script = "Guru", Typeface = "Raavi" },
              new SupplementalFont { Script = "Cans", Typeface = "Euphemia" },
              new SupplementalFont { Script = "Cher", Typeface = "Plantagenet Cherokee" },
              new SupplementalFont { Script = "Yiii", Typeface = "Microsoft Yi Baiti" },
              new SupplementalFont { Script = "Tibt", Typeface = "Microsoft Himalaya" },
              new SupplementalFont { Script = "Thaa", Typeface = "MV Boli" },
              new SupplementalFont { Script = "Deva", Typeface = "Mangal" },
              new SupplementalFont { Script = "Telu", Typeface = "Gautami" },
              new SupplementalFont { Script = "Taml", Typeface = "Latha" },
              new SupplementalFont { Script = "Syrc", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Orya", Typeface = "Kalinga" },
              new SupplementalFont { Script = "Mlym", Typeface = "Kartika" },
              new SupplementalFont { Script = "Laoo", Typeface = "DokChampa" },
              new SupplementalFont { Script = "Sinh", Typeface = "Iskoola Pota" },
              new SupplementalFont { Script = "Mong", Typeface = "Mongolian Baiti" },
              new SupplementalFont { Script = "Viet", Typeface = "Arial" },
              new SupplementalFont { Script = "Uigh", Typeface = "Microsoft Uighur" },
              new SupplementalFont { Script = "Geor", Typeface = "Sylfaen" },
              new SupplementalFont { Script = "Armn", Typeface = "Arial" },
              new SupplementalFont { Script = "Bugi", Typeface = "Leelawadee UI" },
              new SupplementalFont { Script = "Bopo", Typeface = "Microsoft JhengHei" },
              new SupplementalFont { Script = "Java", Typeface = "Javanese Text" },
              new SupplementalFont { Script = "Lisu", Typeface = "Segoe UI" },
              new SupplementalFont { Script = "Mymr", Typeface = "Myanmar Text" },
              new SupplementalFont { Script = "Nkoo", Typeface = "Ebrima" },
              new SupplementalFont { Script = "Olck", Typeface = "Nirmala UI" },
              new SupplementalFont { Script = "Osma", Typeface = "Ebrima" },
              new SupplementalFont { Script = "Phag", Typeface = "Phagspa" },
              new SupplementalFont { Script = "Syrn", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Syrj", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Syre", Typeface = "Estrangelo Edessa" },
              new SupplementalFont { Script = "Sora", Typeface = "Nirmala UI" },
              new SupplementalFont { Script = "Tale", Typeface = "Microsoft Tai Le" },
              new SupplementalFont { Script = "Talu", Typeface = "Microsoft New Tai Lue" },
              new SupplementalFont { Script = "Tfng", Typeface = "Ebrima" },
            ]
          }
        },
        //FormatScheme = new FormatScheme
        //{
        //  Typeface = "Office",
        //  FillStyleList =
        //  [
        //    new SolidFill { Color = new RgbColorModelHex { Val = (HexColor)0xFFFFFF } },
        //    new GradientFill
        //      { RotateWithShape = true,
        //        GradientStopList =
        //        [
        //          new GradientStop { Position = 0, Color = new DMD.SchemeColor() { Val = SchemeColors.PhColor } },
        //          new GradientStop { Position = 0.5, Color = new DMD.SchemeColor() { Val = SchemeColors.PhColor } },
        //          new GradientStop { Position = 1, Color = new DMD.SchemeColor() { Val = SchemeColors.PhColor } },
        //        ],
        //      },
        //    new PatternFill { Type = FillStyleTypeValues.Pattern, Color = new RgbColorModelHex { Val = (HexColor)0x156082 } },
        //  ],
        //},
      },
      //ObjectDefaults = new ObjectDefaults
      //{
      //  LineDefault = new LineDefault
      //  {
      //    Width = 9525,
      //    CapType = LineCapValues.Round,
      //    CompoundLineType = CompoundLineValues.Double,
      //    Alignment = PenAlignmentValues.Center,
      //    ArrowHeadWidth = ArrowHeadWidthValues.Medium,
      //    ArrowHeadLength = ArrowHeadLengthValues.Medium,
      //    ArrowHeadStyle = ArrowHeadStyleValues.Triangle,
      //  },
      //}

    };
    return theme;
  }

}
