namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public static class RunFontsConverter
{
  /// <summary>
  /// Font Content Type
  /// </summary>
  private static DMW.FontTypeHintKind? GetHint(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(openXmlElement?.Hint?.Value);
  }
  
  private static void SetHint(DXW.RunFonts openXmlElement, DMW.FontTypeHintKind? value)
  {
    openXmlElement.Hint = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(value);
  }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  private static String? GetAscii(DXW.RunFonts openXmlElement)
  {
    return openXmlElement?.Ascii?.Value;
  }
  
  private static void SetAscii(DXW.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Ascii = new StringValue { Value = value };
    else
      openXmlElement.Ascii = null;
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  private static String? GetHighAnsi(DXW.RunFonts openXmlElement)
  {
    return openXmlElement?.HighAnsi?.Value;
  }
  
  private static void SetHighAnsi(DXW.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HighAnsi = new StringValue { Value = value };
    else
      openXmlElement.HighAnsi = null;
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  private static String? GetEastAsia(DXW.RunFonts openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  private static void SetEastAsia(DXW.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EastAsia = new StringValue { Value = value };
    else
      openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  private static String? GetComplexScript(DXW.RunFonts openXmlElement)
  {
    return openXmlElement?.ComplexScript?.Value;
  }
  
  private static void SetComplexScript(DXW.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ComplexScript = new StringValue { Value = value };
    else
      openXmlElement.ComplexScript = null;
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  private static DMW.ThemeFontKind? GetAsciiTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }
  
  private static void SetAsciiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.AsciiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  private static DMW.ThemeFontKind? GetHighAnsiTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value);
  }
  
  private static void SetHighAnsiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.HighAnsiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  private static DMW.ThemeFontKind? GetEastAsiaTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value);
  }
  
  private static void SetEastAsiaTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.EastAsiaTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  private static DMW.ThemeFontKind? GetComplexScriptTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value);
  }
  
  private static void SetComplexScriptTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  
  public static DMW.RunFonts? CreateModelElement(DXW.RunFonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunFonts();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunFonts? value)
    where OpenXmlElementType: DXW.RunFonts, new()
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
