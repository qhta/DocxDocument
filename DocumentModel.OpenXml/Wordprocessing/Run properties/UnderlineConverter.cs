namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public static class UnderlineConverter
{
  /// <summary>
  /// Underline Style
  /// </summary>
  private static DMW.UnderlineKind? GetVal(DXW.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.UnderlineValues, DMW.UnderlineKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.Underline openXmlElement, DMW.UnderlineKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.UnderlineValues, DMW.UnderlineKind>(openXmlElement?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVal(DXW.Underline openXmlElement, DMW.UnderlineKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DXW.UnderlineValues, DMW.UnderlineKind>(value);
  }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  private static String? GetColor(DXW.Underline openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.Underline openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXW.Underline openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Underline Theme Color
  /// </summary>
  private static DMW.ThemeColorIndex? GetThemeColor(DXW.Underline openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXW.Underline openXmlElement, DMW.ThemeColorIndex? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(openXmlElement?.ThemeColor?.Value, value, diffs, objName, propName);
  }
  
  private static void SetThemeColor(DXW.Underline openXmlElement, DMW.ThemeColorIndex? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DXW.ThemeColorValues, DMW.ThemeColorIndex>(value);
  }
  
  /// <summary>
  /// Underline Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DXW.Underline openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.Underline openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "Tint");
  }
  
  private static void SetThemeTint(DXW.Underline openXmlElement, String? value)
  {
    openXmlElement.ThemeTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Underline Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.Underline openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.Underline openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "Shade");
  }
  
  private static void SetThemeShade(DXW.Underline openXmlElement, String? value)
  {
    openXmlElement.ThemeShade = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Underline? CreateModelElement(DXW.Underline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Underline();
      value.Type = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.Underline? openXmlElement, DMW.Underline? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName, propName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName, propName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName, propName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Underline value)
    where OpenXmlElementType: DXW.Underline, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Underline openXmlElement, DMW.Underline value)
  {
    SetVal(openXmlElement, value?.Type);
    SetColor(openXmlElement, value?.Color);
    SetThemeColor(openXmlElement, value?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ThemeShade);
  }
}
