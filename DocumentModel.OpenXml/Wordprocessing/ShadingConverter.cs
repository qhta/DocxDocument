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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues, DMW.ShadingPatternKind>(openXmlElement?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Color?.Value;
  }
  
  private static bool CmpColor(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color?.Value == value) return true;
    diffs?.Add(objName, "Color", openXmlElement?.Color?.Value, value);
    return false;
  }
  
  private static void SetColor(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static bool CmpThemeTint(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeTint?.Value == value) return true;
    diffs?.Add(objName, "ThemeTint", openXmlElement?.ThemeTint?.Value, value);
    return false;
  }
  
  private static void SetThemeTint(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static bool CmpThemeShade(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeShade?.Value == value) return true;
    diffs?.Add(objName, "ThemeShade", openXmlElement?.ThemeShade?.Value, value);
    return false;
  }
  
  private static void SetThemeShade(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  private static String? GetFill(DXW.Shading openXmlElement)
  {
    return openXmlElement?.Fill?.Value;
  }
  
  private static bool CmpFill(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Fill?.Value == value) return true;
    diffs?.Add(objName, "Fill", openXmlElement?.Fill?.Value, value);
    return false;
  }
  
  private static void SetFill(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Fill = new StringValue { Value = value };
    else
      openXmlElement.Fill = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeFill?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ThemeFillTint?.Value;
  }
  
  private static bool CmpThemeFillTint(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeFillTint?.Value == value) return true;
    diffs?.Add(objName, "ThemeFillTint", openXmlElement?.ThemeFillTint?.Value, value);
    return false;
  }
  
  private static void SetThemeFillTint(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeFillTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeFillTint = null;
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  private static String? GetThemeFillShade(DXW.Shading openXmlElement)
  {
    return openXmlElement?.ThemeFillShade?.Value;
  }
  
  private static bool CmpThemeFillShade(DXW.Shading openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeFillShade?.Value == value) return true;
    diffs?.Add(objName, "ThemeFillShade", openXmlElement?.ThemeFillShade?.Value, value);
    return false;
  }
  
  private static void SetThemeFillShade(DXW.Shading openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeFillShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeFillShade = null;
  }
  
  public static DocumentModel.Wordprocessing.Shading? CreateModelElement(DXW.Shading? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Shading();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Shading? value)
    where OpenXmlElementType: DXW.Shading, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetFill(openXmlElement, value?.Fill);
      SetThemeFill(openXmlElement, value?.ThemeFill);
      SetThemeFillTint(openXmlElement, value?.ThemeFillTint);
      SetThemeFillShade(openXmlElement, value?.ThemeFillShade);
      return openXmlElement;
    }
    return default;
  }
}
