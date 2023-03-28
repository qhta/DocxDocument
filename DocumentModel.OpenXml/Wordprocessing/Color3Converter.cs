namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Color Class converter from/to OpenXml.
///</summary>
public static class Color3Converter
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  private static String? GetVal(DXO2013W.Color openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Normal");
  }
  
  private static void SetVal(DXO2013W.Color openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Run Content Theme Color
  /// </summary>
  private static DMW.ThemeColorKind? GetThemeColor(DXO2013W.Color openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXO2013W.Color openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }
  
  private static void SetThemeColor(DXO2013W.Color openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Run Content Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DXO2013W.Color openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXO2013W.Color openXmlElement, String? value)
  {
    openXmlElement.ThemeTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXO2013W.Color openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXO2013W.Color openXmlElement, String? value)
  {
    openXmlElement.ThemeShade = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.Color3? CreateModelElement(DXO2013W.Color? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Color3();
      value.Val = GetVal(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013W.Color? openXmlElement, DMW.Color3? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Color3 value)
    where OpenXmlElementType: DXO2013W.Color, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013W.Color openXmlElement, DMW.Color3 value)
  {
    SetVal(openXmlElement, value?.Val);
    SetThemeColor(openXmlElement, value?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ThemeShade);
  }
}
