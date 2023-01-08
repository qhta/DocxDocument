namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunFonts Class.
/// </summary>
public static class RunFontsConverter
{
  /// <summary>
  /// Font Content Type
  /// </summary>
  public static DocumentModel.Wordprocessing.FontTypeHintKind? GetHint(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DocumentModel.Wordprocessing.FontTypeHintKind>(openXmlElement?.Hint?.Value);
  }
  
  public static void SetHint(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, DocumentModel.Wordprocessing.FontTypeHintKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Hint = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DocumentModel.Wordprocessing.FontTypeHintKind>(value);
  }
  
  /// <summary>
  /// ASCII Font
  /// </summary>
  public static String? GetAscii(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetAscii(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public static String? GetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public static String? GetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public static String? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeFontKind? GetAsciiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }
  
  public static void SetAsciiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AsciiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// High ANSI Theme Font
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeFontKind? GetHighAnsiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value);
  }
  
  public static void SetHighAnsiTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.HighAnsiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// East Asian Theme Font
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeFontKind? GetEastAsiaTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value);
  }
  
  public static void SetEastAsiaTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EastAsiaTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
  /// <summary>
  /// Complex Script Theme Font
  /// </summary>
  public static DocumentModel.Wordprocessing.ThemeFontKind? GetComplexScriptTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value);
  }
  
  public static void SetComplexScriptTheme(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, DocumentModel.Wordprocessing.ThemeFontKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DocumentModel.Wordprocessing.ThemeFontKind>(value);
  }
  
}
