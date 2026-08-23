using DocumentModel.Drawings;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Creates a base class for theme-related tests, providing utility methods for setting up document contexts with initialized themes and color schemes. This class serves as a foundation for testing theme and color functionality in Wordprocessing documents, ensuring that color instances can be properly attached to document contexts for accurate testing of ParentDocument-dependent behavior.
/// </summary>
public abstract class BaseThemeTest : _AbstractTestClass
{

  /// <summary>
  /// Attaches a color instance to the document context to enable ParentDocument-dependent behavior.
  /// </summary>
  /// <param name="color">Color instance to attach.</param>
  /// <param name="document">Document context containing initialized theme data.</param>
  public void AttachToDocumentContext(object color, DocumentModel.Wordprocessing.Document document)
  {
    if (color is ModelElement modelElement)
      modelElement.SetParent(document);
  }

  /// <summary>
  /// Creates a document context initialized with a theme and color scheme.
  /// </summary>
  /// <returns>Document context for color tests.</returns>
  public DocumentModel.Wordprocessing.Document CreateDocumentWithInitializedThemePart()
  {
    var document = new DocumentModel.Wordprocessing.Document();
    document.Theme = CreateThemeWithColorScheme();
    return document;
  }

  /// <summary>
  /// Initializes the document theme part with a basic color scheme.
  /// </summary>
  public Theme CreateThemeWithColorScheme()
  {

    var theme = new Theme
    {
      Name = "Office Theme",
      ThemeElements = new ThemeElements()
    };

    var colorScheme = new ColorScheme
    {
      Name = "Office",
    };
    theme.ThemeElements.ColorScheme = colorScheme;

    colorScheme.Dark1Color = new SystemColor { Index = SystemColors.WindowText, LastColor = (HexColor)0x000000 };
    colorScheme.Light1Color = new SystemColor { Index = SystemColors.Window, LastColor = (HexColor)0xFFFFFF };
    colorScheme.Dark2Color = new RgbColorModelHex { Value = (HexColor)0x336699 };
    colorScheme.Light2Color = new RgbColorModelHex { Value = (HexColor)0xE8E8E8 };
    colorScheme.Accent1Color = new RgbColorModelHex { Value = (HexColor)0x156082 };
    colorScheme.Accent2Color = new RgbColorModelHex { Value = (HexColor)0xE97132 };
    colorScheme.Accent3Color = new RgbColorModelHex { Value = (HexColor)0xE97132 };
    colorScheme.Accent4Color = new RgbColorModelHex { Value = (HexColor)0x0F9ED5 };
    colorScheme.Accent5Color = new RgbColorModelHex { Value = (HexColor)0xA02B93 };
    colorScheme.Accent6Color = new RgbColorModelHex { Value = (HexColor)0x4EA72E };
    colorScheme.Hyperlink = new RgbColorModelHex { Value = (HexColor)0x0467886 };
    colorScheme.FollowedHyperlink = new RgbColorModelHex { Value = (HexColor)0x96607D };

    theme.ThemeElements.FontScheme = new FontScheme
    {
      Name = "Office",
      MajorFont = new MajorFont
      {
        LatinFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xEE },
        EastAsianFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0x80 },
        ComplexScriptFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xB1 },
      },
      MinorFont = new MinorFont()
      {
        LatinFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xEE },
        EastAsianFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0x80 },
        ComplexScriptFont = new DMD.TextFontType { Typeface = "Aptos Display", Panose = new HexBinary("02110004020202020204"), Charset = 0xB1 },
      }
    };
    return theme;
  }

}