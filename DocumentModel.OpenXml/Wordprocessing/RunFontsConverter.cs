using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using RunFonts = DocumentFormat.OpenXml.Wordprocessing.RunFonts;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the RunFonts Class.
/// </summary>
public static class RunFontsConverter
{
  /// <summary>
  ///   Font Content Type
  /// </summary>
  public static FontTypeHintKind? GetHint(RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<FontTypeHintValues, FontTypeHintKind>(openXmlElement?.Hint?.Value);
  }

  public static void SetHint(RunFonts? openXmlElement, FontTypeHintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hint = EnumValueConverter.CreateEnumValue<FontTypeHintValues, FontTypeHintKind>(value);
  }

  /// <summary>
  ///   ASCII Font
  /// </summary>
  public static String? GetAscii(RunFonts? openXmlElement)
  {
    return openXmlElement?.Ascii?.Value;
  }

  public static void SetAscii(RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ascii = new StringValue { Value = value };
      else
        openXmlElement.Ascii = null;
  }

  /// <summary>
  ///   High ANSI Font
  /// </summary>
  public static String? GetHighAnsi(RunFonts? openXmlElement)
  {
    return openXmlElement?.HighAnsi?.Value;
  }

  public static void SetHighAnsi(RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HighAnsi = new StringValue { Value = value };
      else
        openXmlElement.HighAnsi = null;
  }

  /// <summary>
  ///   East Asian Font
  /// </summary>
  public static String? GetEastAsia(RunFonts? openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }

  public static void SetEastAsia(RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsia = new StringValue { Value = value };
      else
        openXmlElement.EastAsia = null;
  }

  /// <summary>
  ///   Complex Script Font
  /// </summary>
  public static String? GetComplexScript(RunFonts? openXmlElement)
  {
    return openXmlElement?.ComplexScript?.Value;
  }

  public static void SetComplexScript(RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ComplexScript = new StringValue { Value = value };
      else
        openXmlElement.ComplexScript = null;
  }

  /// <summary>
  ///   ASCII Theme Font
  /// </summary>
  public static ThemeFontKind? GetAsciiTheme(RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeFontValues, ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }

  public static void SetAsciiTheme(RunFonts? openXmlElement, ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AsciiTheme = EnumValueConverter.CreateEnumValue<ThemeFontValues, ThemeFontKind>(value);
  }

  /// <summary>
  ///   High ANSI Theme Font
  /// </summary>
  public static ThemeFontKind? GetHighAnsiTheme(RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeFontValues, ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value);
  }

  public static void SetHighAnsiTheme(RunFonts? openXmlElement, ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HighAnsiTheme = EnumValueConverter.CreateEnumValue<ThemeFontValues, ThemeFontKind>(value);
  }

  /// <summary>
  ///   East Asian Theme Font
  /// </summary>
  public static ThemeFontKind? GetEastAsiaTheme(RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeFontValues, ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value);
  }

  public static void SetEastAsiaTheme(RunFonts? openXmlElement, ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EastAsiaTheme = EnumValueConverter.CreateEnumValue<ThemeFontValues, ThemeFontKind>(value);
  }

  /// <summary>
  ///   Complex Script Theme Font
  /// </summary>
  public static ThemeFontKind? GetComplexScriptTheme(RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<ThemeFontValues, ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value);
  }

  public static void SetComplexScriptTheme(RunFonts? openXmlElement, ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<ThemeFontValues, ThemeFontKind>(value);
  }

  public static DocumentModel.Wordprocessing.RunFonts? CreateModelElement(RunFonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RunFonts();
      value.Hint = GetHint(openXmlElement);
      value.Ascii = GetAscii(openXmlElement);
      value.HighAnsi = GetHighAnsi(openXmlElement);
      value.EastAsia = GetEastAsia(openXmlElement);
      value.ComplexScript = GetComplexScript(openXmlElement);
      value.AsciiTheme = GetAsciiTheme(openXmlElement);
      value.HighAnsiTheme = GetHighAnsiTheme(openXmlElement);
      value.EastAsiaTheme = GetEastAsiaTheme(openXmlElement);
      value.ComplexScriptTheme = GetComplexScriptTheme(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RunFonts? value)
    where OpenXmlElementType : RunFonts, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHint(openXmlElement, value?.Hint);
      SetAscii(openXmlElement, value?.Ascii);
      SetHighAnsi(openXmlElement, value?.HighAnsi);
      SetEastAsia(openXmlElement, value?.EastAsia);
      SetComplexScript(openXmlElement, value?.ComplexScript);
      SetAsciiTheme(openXmlElement, value?.AsciiTheme);
      SetHighAnsiTheme(openXmlElement, value?.HighAnsiTheme);
      SetEastAsiaTheme(openXmlElement, value?.EastAsiaTheme);
      SetComplexScriptTheme(openXmlElement, value?.ComplexScriptTheme);
      return openXmlElement;
    }
    return default;
  }
}