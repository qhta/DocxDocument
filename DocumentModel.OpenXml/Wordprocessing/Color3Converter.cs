namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public static class Color3Converter
{
  /// <summary>
  /// Run Content Color
  /// </summary>
  private static String? GetVal(DXO2013W.Color openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static bool CmpVal(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Val?.Value == value) return true;
    diffs?.Add(objName, "Val", openXmlElement?.Val?.Value, value);
    return false;
  }
  
  private static void SetVal(DXO2013W.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static bool CmpThemeTint(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeTint?.Value == value) return true;
    diffs?.Add(objName, "ThemeTint", openXmlElement?.ThemeTint?.Value, value);
    return false;
  }
  
  private static void SetThemeTint(DXO2013W.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXO2013W.Color openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static bool CmpThemeShade(DXO2013W.Color openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeShade?.Value == value) return true;
    diffs?.Add(objName, "ThemeShade", openXmlElement?.ThemeShade?.Value, value);
    return false;
  }
  
  private static void SetThemeShade(DXO2013W.Color openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Color3? value)
    where OpenXmlElementType: DXO2013W.Color, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      return openXmlElement;
    }
    return default;
  }
}
