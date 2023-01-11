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
    return openXmlElement?.Ascii?.Value;
  }
  
  public static void SetAscii(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ascii = new StringValue { Value = value };
      else
        openXmlElement.Ascii = null;
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  public static String? GetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return openXmlElement?.HighAnsi?.Value;
  }
  
  public static void SetHighAnsi(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HighAnsi = new StringValue { Value = value };
      else
        openXmlElement.HighAnsi = null;
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  public static String? GetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return openXmlElement?.EastAsia?.Value;
  }
  
  public static void SetEastAsia(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.EastAsia = new StringValue { Value = value };
      else
        openXmlElement.EastAsia = null;
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  public static String? GetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement)
  {
    return openXmlElement?.ComplexScript?.Value;
  }
  
  public static void SetComplexScript(DocumentFormat.OpenXml.Wordprocessing.RunFonts? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ComplexScript = new StringValue { Value = value };
      else
        openXmlElement.ComplexScript = null;
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
