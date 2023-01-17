namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public static class RunFontsConverter
{
  /// <summary>
  /// Font Content Type
  /// </summary>
  private static DocumentModel.Wordprocessing.FontTypeHintKind? GetHint(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DocumentModel.Wordprocessing.FontTypeHintKind>(openXmlElement?.Hint?.Value);
  }
  
  private static void SetHint(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, DocumentModel.Wordprocessing.FontTypeHintKind? value)
  {
    openXmlElement.Hint = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DocumentModel.Wordprocessing.FontTypeHintKind>(value);
  }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  private static String? GetAscii(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return openXmlElement?.Ascii?.Value;
  }
  
  private static void SetAscii(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Ascii = new StringValue { Value = value };
    else
      openXmlElement.Ascii = null;
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  private static String? GetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return openXmlElement?.HighAnsi?.Value;
  }
  
  private static void SetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HighAnsi = new StringValue { Value = value };
    else
      openXmlElement.HighAnsi = null;
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  private static String? GetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  private static void SetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.EastAsia = new StringValue { Value = value };
    else
      openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  private static String? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return openXmlElement?.ComplexScript?.Value;
  }
  
  private static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ComplexScript = new StringValue { Value = value };
    else
      openXmlElement.ComplexScript = null;
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeFontKind? GetAsciiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }
  
  private static void SetAsciiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    openXmlElement.AsciiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeFontKind? GetHighAnsiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value);
  }
  
  private static void SetHighAnsiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    openXmlElement.HighAnsiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeFontKind? GetEastAsiaTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value);
  }
  
  private static void SetEastAsiaTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    openXmlElement.EastAsiaTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  private static DocumentModel.Wordprocessing.ThemeFontKind? GetComplexScriptTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value);
  }
  
  private static void SetComplexScriptTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.RunFonts? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RunFonts, new()
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
