using DM = DocxDocument.Model;
using OpenXml = DocumentFormat.OpenXml;
using WP = DocumentFormat.OpenXml.Wordprocessing;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DM.RunProperties ReadRunProperties(OpenXml.OpenXmlCompositeElement openXmlElement)
  {
    var dmRunProperties = new DM.RunProperties();
    foreach (var element in openXmlElement.Elements())
    {
      if (element is WP.RunFonts wpRunFonts)
        dmRunProperties.FontNames = ReadFontNames(wpRunFonts);
      else if (element is WP.FontSize wpFontSize)
        dmRunProperties.FontSize = ReadHpsMeasure(wpFontSize.Val);
      else if (element is WP.FontSizeComplexScript wpFontSizeComplexScript)
        dmRunProperties.FontSizeBi = ReadHpsMeasure(wpFontSizeComplexScript.Val);
      else if (element is WP.Languages wpLanguages)
        dmRunProperties.Languages = ReadLanguages(wpLanguages);
    }
    return dmRunProperties;
  }

  private DM.FontNames ReadFontNames(WP.RunFonts wpRunFonts)
  {
    var dmFontNames = new DM.FontNames();
    dmFontNames.Ascii = wpRunFonts.Ascii;
    dmFontNames.ComplexScript = wpRunFonts.ComplexScript;
    dmFontNames.EastAsia = wpRunFonts.EastAsia;
    dmFontNames.HighAnsi = wpRunFonts.HighAnsi;
    dmFontNames.AsciiTheme = wpRunFonts.AsciiTheme?.ToString();
    dmFontNames.ComplexScriptTheme = wpRunFonts.ComplexScriptTheme?.ToString();
    dmFontNames.EastAsiaTheme = wpRunFonts.EastAsiaTheme?.ToString();
    dmFontNames.HighAnsiTheme = wpRunFonts.HighAnsiTheme?.ToString();
    dmFontNames.Hint = (DM.FontTypeHint?)(wpRunFonts.Hint?.Value);
    return dmFontNames;
  }

  private float? ReadHpsMeasure(string? valStr)
  {
    if (valStr==null)
      return null;
    if (UInt64.TryParse(valStr, out var val))
      return (float)val / 2;
    else
      throw new InvalidOperationException($"Cant convert \"{valStr}\" string to UInt64");
  }

  private DM.Languages ReadLanguages(WP.Languages wpLanguages)
  {
    var dmLanguages = new DM.Languages();
    dmLanguages.Latin = wpLanguages.Val;
    dmLanguages.ComplexScript = wpLanguages.Bidi;
    dmLanguages.EastAsia = wpLanguages.EastAsia;
    return dmLanguages;
  }
}