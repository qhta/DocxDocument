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
  
  private static bool CmpHint(DXW.RunFonts openXmlElement, DMW.FontTypeHintKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(openXmlElement?.Hint?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return StringValueConverter.GetValue(openXmlElement?.Ascii);
  }
  
  private static bool CmpAscii(DXW.RunFonts openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Ascii, value, diffs, objName, "Ascii");
  }
  
  private static void SetAscii(DXW.RunFonts openXmlElement, String? value)
  {
    openXmlElement.Ascii = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// High ANSI Font
  /// </summary>
  private static String? GetHighAnsi(DXW.RunFonts openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.HighAnsi);
  }
  
  private static bool CmpHighAnsi(DXW.RunFonts openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.HighAnsi, value, diffs, objName, "HighAnsi");
  }
  
  private static void SetHighAnsi(DXW.RunFonts openXmlElement, String? value)
  {
    openXmlElement.HighAnsi = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// East Asian Font
  /// </summary>
  private static String? GetEastAsia(DXW.RunFonts openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.EastAsia);
  }
  
  private static bool CmpEastAsia(DXW.RunFonts openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.EastAsia, value, diffs, objName, "EastAsia");
  }
  
  private static void SetEastAsia(DXW.RunFonts openXmlElement, String? value)
  {
    openXmlElement.EastAsia = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Complex Script Font
  /// </summary>
  private static String? GetComplexScript(DXW.RunFonts openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ComplexScript);
  }
  
  private static bool CmpComplexScript(DXW.RunFonts openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ComplexScript, value, diffs, objName, "ComplexScript");
  }
  
  private static void SetComplexScript(DXW.RunFonts openXmlElement, String? value)
  {
    openXmlElement.ComplexScript = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// ASCII Theme Font
  /// </summary>
  private static DMW.ThemeFontKind? GetAsciiTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }
  
  private static bool CmpAsciiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpHighAnsiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpEastAsiaTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  private static bool CmpComplexScriptTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetComplexScriptTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.RunFonts? CreateModelElement(DXW.RunFonts? openXmlElement)
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
  
  public static bool CompareModelElement(DXW.RunFonts? openXmlElement, DMW.RunFonts? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpHint(openXmlElement, value.Hint, diffs, objName))
        ok = false;
      if (!CmpAscii(openXmlElement, value.Ascii, diffs, objName))
        ok = false;
      if (!CmpHighAnsi(openXmlElement, value.HighAnsi, diffs, objName))
        ok = false;
      if (!CmpEastAsia(openXmlElement, value.EastAsia, diffs, objName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, value.ComplexScript, diffs, objName))
        ok = false;
      if (!CmpAsciiTheme(openXmlElement, value.AsciiTheme, diffs, objName))
        ok = false;
      if (!CmpHighAnsiTheme(openXmlElement, value.HighAnsiTheme, diffs, objName))
        ok = false;
      if (!CmpEastAsiaTheme(openXmlElement, value.EastAsiaTheme, diffs, objName))
        ok = false;
      if (!CmpComplexScriptTheme(openXmlElement, value.ComplexScriptTheme, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunFonts value)
    where OpenXmlElementType: DXW.RunFonts, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RunFonts openXmlElement, DMW.RunFonts value)
  {
    SetHint(openXmlElement, value?.Hint);
    SetAscii(openXmlElement, value?.Ascii);
    SetHighAnsi(openXmlElement, value?.HighAnsi);
    SetEastAsia(openXmlElement, value?.EastAsia);
    SetComplexScript(openXmlElement, value?.ComplexScript);
    SetAsciiTheme(openXmlElement, value?.AsciiTheme);
    SetHighAnsiTheme(openXmlElement, value?.HighAnsiTheme);
    SetEastAsiaTheme(openXmlElement, value?.EastAsiaTheme);
    SetComplexScriptTheme(openXmlElement, value?.ComplexScriptTheme);
    }
  }
