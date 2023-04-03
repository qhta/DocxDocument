namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  #region Shading Pattern conversion.
  private static DMW.ShadingPatternKind? GetVal(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.Shading openXmlElement, DMW.ShadingPatternKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.Shading openXmlElement, DMW.ShadingPatternKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(value);
  }
  #endregion
 
  #region RGB Color conversion.
  private static RGB? GetColor(DXW.Shading openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.Shading openXmlElement, RGB? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Value");
  }
  
  private static void SetColor(DXW.Shading openXmlElement, RGB? value)
  {
    openXmlElement.Color = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Shading Pattern Theme Color conversion
  private static DMW.ThemeColorKind? GetThemeColor(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXW.Shading openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }
  
  private static void SetThemeColor(DXW.Shading openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  #endregion
  
  #region ThemeTint conversion
  private static BytePercent? GetThemeTint(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.Shading openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.Shading openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ThemeShade conversion
  private static BytePercent? GetThemeShade(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.Shading openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.Shading openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Shading Background Color conversion
  private static RGB? GetFill(DXW.Shading openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Fill);
  }
  
  private static bool CmpFill(DXW.Shading openXmlElement, RGB? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Fill, value, diffs, objName, "Fill");
  }
  
  private static void SetFill(DXW.Shading openXmlElement, RGB? value)
  {
    openXmlElement.Fill = ColorValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Shading Background Theme Color conversion
  private static DMW.ThemeColorKind? GetThemeFill(DXW.Shading openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeFill?.Value);
  }
  
  private static bool CmpThemeFill(DXW.Shading openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeFill?.Value, value, diffs, objName);
  }
  
  private static void SetThemeFill(DXW.Shading openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeFill = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  #endregion

  #region Shading Background Theme Color Tint
  private static BytePercent? GetThemeFillTint(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeFillTint);
  }
  
  private static bool CmpThemeFillTint(DXW.Shading openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeFillTint, value, diffs, objName, "ThemeFillTint");
  }
  
  private static void SetThemeFillTint(DXW.Shading openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeFillTint = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Shading Background Theme Color Shade
  private static BytePercent? GetThemeFillShade(DXW.Shading openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeFillShade);
  }
  
  private static bool CmpThemeFillShade(DXW.Shading openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeFillShade, value, diffs, objName, "ThemeFillShade");
  }
  
  private static void SetThemeFillShade(DXW.Shading openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeFillShade = BytePercentValueConverter.CreateStringValue(value);
  }
  #endregion

  #region Shading model conversion
  public static DMW.Shading? CreateModelElement(DXW.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Shading();
      value.Pattern = GetVal(openXmlElement);
      var foregroundColor = new DMW.Color();
      foregroundColor.RGB = GetColor(openXmlElement);
      foregroundColor.ThemeColor = GetThemeColor(openXmlElement);
      foregroundColor.ThemeTint = GetThemeTint(openXmlElement);
      foregroundColor.ThemeShade = GetThemeShade(openXmlElement);
      if (!foregroundColor.IsEmpty())
        value.ForegroundColor = foregroundColor;
      var backgroundColor = new DMW.Color();
      backgroundColor.RGB = GetFill(openXmlElement);
      backgroundColor.ThemeColor = GetThemeFill(openXmlElement);
      backgroundColor.ThemeTint = GetThemeFillTint(openXmlElement);
      backgroundColor.ThemeShade = GetThemeFillShade(openXmlElement);
      if (!backgroundColor.IsEmpty())
        value.BackgroundColor = backgroundColor;
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Shading? openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Pattern, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.ForegroundColor?.RGB, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ForegroundColor?.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ForegroundColor?.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ForegroundColor?.ThemeShade, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.ForegroundColor?.RGB, diffs, objName))
        ok = false;
      if (!CmpThemeFill(openXmlElement, value.ForegroundColor?.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeFillTint(openXmlElement, value.ForegroundColor?.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeFillShade(openXmlElement, value.ForegroundColor?.ThemeShade, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Shading value)
    where OpenXmlElementType: DXW.Shading, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Shading openXmlElement, DMW.Shading value)
  {
    SetVal(openXmlElement, value?.Pattern);
    SetColor(openXmlElement, value?.ForegroundColor?.RGB);
    SetThemeColor(openXmlElement, value?.ForegroundColor?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ForegroundColor?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ForegroundColor?.ThemeShade);
    SetFill(openXmlElement, value?.ForegroundColor?.RGB);
    SetThemeFill(openXmlElement, value?.ForegroundColor?.ThemeColor);
    SetThemeFillTint(openXmlElement, value?.ForegroundColor?.ThemeTint);
    SetThemeFillShade(openXmlElement, value?.ForegroundColor?.ThemeShade);
  }
  #endregion
}
