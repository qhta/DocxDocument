namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.RunFonts"/> class from/to OpenXml converter.
/// </summary>
public static class RunFontsConverter
{
  #region Font Content Type conversion.
  private static DMW.FontTypeHintKind? GetHint(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(openXmlElement?.Hint?.Value);
  }
  
  private static bool CmpHint(DXW.RunFonts openXmlElement, DMW.FontTypeHintKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(openXmlElement?.Hint?.Value, value, diffs, objName);
  }
  
  private static void SetHint(DXW.RunFonts openXmlElement, DMW.FontTypeHintKind? value)
  {
    openXmlElement.Hint = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FontTypeHintValues, DMW.FontTypeHintKind>(value);
  }
  #endregion

  #region ASCII Font conversion.
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
#endregion

  #region High ANSI Font conversion.
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
#endregion

  #region East Asian Font conversion.
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
#endregion

  #region ASCII Theme Font conversion.
  private static DMW.ThemeFontKind? GetAsciiTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value);
  }
  
  private static bool CmpAsciiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.AsciiTheme?.Value, value, diffs, objName);
  }
  
  private static void SetAsciiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.AsciiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
#endregion

  #region High ANSI Theme Font conversion.
  private static DMW.ThemeFontKind? GetHighAnsiTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value);
  }
  
  private static bool CmpHighAnsiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.HighAnsiTheme?.Value, value, diffs, objName);
  }
  
  private static void SetHighAnsiTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.HighAnsiTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
#endregion

  #region East Asian Theme Font conversion.
  private static DMW.ThemeFontKind? GetEastAsiaTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value);
  }
  
  private static bool CmpEastAsiaTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.EastAsiaTheme?.Value, value, diffs, objName);
  }
  
  private static void SetEastAsiaTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.EastAsiaTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
#endregion

  #region Complex Script Theme Font conversion.
  private static DMW.ThemeFontKind? GetComplexScriptTheme(DXW.RunFonts openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value);
  }
  
  private static bool CmpComplexScriptTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(openXmlElement?.ComplexScriptTheme?.Value, value, diffs, objName);
  }
  
  private static void SetComplexScriptTheme(DXW.RunFonts openXmlElement, DMW.ThemeFontKind? value)
  {
    openXmlElement.ComplexScriptTheme = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeFontValues, DMW.ThemeFontKind>(value);
  }
  #endregion

  #region RunFonts model conversion.
  public static DMW.RunFonts? CreateModelElement(DXW.RunFonts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.RunFonts();
      model.Hint = GetHint(openXmlElement);
      model.Ascii = GetAscii(openXmlElement);
      model.HighAnsi = GetHighAnsi(openXmlElement);
      model.EastAsia = GetEastAsia(openXmlElement);
      model.ComplexScript = GetComplexScript(openXmlElement);
      model.AsciiTheme = GetAsciiTheme(openXmlElement);
      model.HighAnsiTheme = GetHighAnsiTheme(openXmlElement);
      model.EastAsiaTheme = GetEastAsiaTheme(openXmlElement);
      model.ComplexScriptTheme = GetComplexScriptTheme(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.RunFonts? openXmlElement, DMW.RunFonts? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpHint(openXmlElement, model.Hint, diffs, objName))
        ok = false;
      if (!CmpAscii(openXmlElement, model.Ascii, diffs, objName))
        ok = false;
      if (!CmpHighAnsi(openXmlElement, model.HighAnsi, diffs, objName))
        ok = false;
      if (!CmpEastAsia(openXmlElement, model.EastAsia, diffs, objName))
        ok = false;
      if (!CmpComplexScript(openXmlElement, model.ComplexScript, diffs, objName))
        ok = false;
      if (!CmpAsciiTheme(openXmlElement, model.AsciiTheme, diffs, objName))
        ok = false;
      if (!CmpHighAnsiTheme(openXmlElement, model.HighAnsiTheme, diffs, objName))
        ok = false;
      if (!CmpEastAsiaTheme(openXmlElement, model.EastAsiaTheme, diffs, objName))
        ok = false;
      if (!CmpComplexScriptTheme(openXmlElement, model.ComplexScriptTheme, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RunFonts model)
    where OpenXmlElementType: DXW.RunFonts, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.RunFonts openXmlElement, DMW.RunFonts model)
  {
    SetHint(openXmlElement, model?.Hint);
    SetAscii(openXmlElement, model?.Ascii);
    SetHighAnsi(openXmlElement, model?.HighAnsi);
    SetEastAsia(openXmlElement, model?.EastAsia);
    SetComplexScript(openXmlElement, model?.ComplexScript);
    SetAsciiTheme(openXmlElement, model?.AsciiTheme);
    SetHighAnsiTheme(openXmlElement, model?.HighAnsiTheme);
    SetEastAsiaTheme(openXmlElement, model?.EastAsiaTheme);
    SetComplexScriptTheme(openXmlElement, model?.ComplexScriptTheme);
  }
  #endregion
}
