namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public static class ShadingConverter
{
  /// <summary>
  /// Shading Pattern
  /// </summary>
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
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  private static String? GetColor(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
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
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.ThemeTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.ThemeShade = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  private static String? GetFill(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Fill);
  }
  
  private static bool CmpFill(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Fill, value, diffs, objName, "Fill");
  }
  
  private static void SetFill(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.Fill = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
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
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  private static String? GetThemeFillTint(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeFillTint);
  }
  
  private static bool CmpThemeFillTint(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeFillTint, value, diffs, objName, "ThemeFillTint");
  }
  
  private static void SetThemeFillTint(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.ThemeFillTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  private static String? GetThemeFillShade(DXW.Shading openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeFillShade);
  }
  
  private static bool CmpThemeFillShade(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeFillShade, value, diffs, objName, "ThemeFillShade");
  }
  
  private static void SetThemeFillShade(DXW.Shading openXmlElement, String? value)
  {
    openXmlElement.ThemeFillShade = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Shading? CreateModelElement(DXW.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Shading();
      value.Val = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Fill = GetFill(openXmlElement);
      value.ThemeFill = GetThemeFill(openXmlElement);
      value.ThemeFillTint = GetThemeFillTint(openXmlElement);
      value.ThemeFillShade = GetThemeFillShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Shading? openXmlElement, DMW.Shading? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName))
        ok = false;
      if (!CmpFill(openXmlElement, value.Fill, diffs, objName))
        ok = false;
      if (!CmpThemeFill(openXmlElement, value.ThemeFill, diffs, objName))
        ok = false;
      if (!CmpThemeFillTint(openXmlElement, value.ThemeFillTint, diffs, objName))
        ok = false;
      if (!CmpThemeFillShade(openXmlElement, value.ThemeFillShade, diffs, objName))
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
    SetVal(openXmlElement, value?.Val);
    SetColor(openXmlElement, value?.Color);
    SetThemeColor(openXmlElement, value?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ThemeShade);
    SetFill(openXmlElement, value?.Fill);
    SetThemeFill(openXmlElement, value?.ThemeFill);
    SetThemeFillTint(openXmlElement, value?.ThemeFillTint);
    SetThemeFillShade(openXmlElement, value?.ThemeFillShade);
  }
}
