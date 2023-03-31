namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public static class BorderTypeConverter
{
  /// <summary>
  /// Border Style
  /// </summary>
  private static DMW.BorderKind? GetVal(DXW.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DMW.BorderKind>(openXmlElement?.Val?.Value);
  }
  
  private static bool CmpVal(DXW.BorderType openXmlElement, DMW.BorderKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DMW.BorderKind>(openXmlElement?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetVal(DXW.BorderType openXmlElement, DMW.BorderKind? value)
  {
    openXmlElement.Val = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DMW.BorderKind>(value);
  }
  
  /// <summary>
  /// Border Color
  /// </summary>
  private static String? GetColor(DXW.BorderType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXW.BorderType openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  private static DMW.ThemeColorKind? GetThemeColor(DXW.BorderType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXW.BorderType openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }
  
  private static void SetThemeColor(DXW.BorderType openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// Border Theme Color Tint
  /// </summary>
  private static String? GetThemeTint(DXW.BorderType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.BorderType openXmlElement, String? value)
  {
    openXmlElement.ThemeTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.BorderType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.BorderType openXmlElement, String? value)
  {
    openXmlElement.ThemeShade = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static UInt32? GetSize(DXW.BorderType openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }
  
  private static bool CmpSize(DXW.BorderType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value) return true;
    diffs?.Add(objName, "Size", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXW.BorderType openXmlElement, UInt32? value)
  {
    openXmlElement.Size = value;
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  private static UInt32? GetSpace(DXW.BorderType openXmlElement)
  {
    return openXmlElement?.Space?.Value;
  }
  
  private static bool CmpSpace(DXW.BorderType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Space?.Value == value) return true;
    diffs?.Add(objName, "Space", openXmlElement?.Space?.Value, value);
    return false;
  }
  
  private static void SetSpace(DXW.BorderType openXmlElement, UInt32? value)
  {
    openXmlElement.Space = value;
  }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  private static Boolean? GetShadow(DXW.BorderType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Shadow);
  }
  
  private static bool CmpShadow(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Shadow, value, diffs, objName, "Shadow");
  }
  
  private static void SetShadow(DXW.BorderType openXmlElement, Boolean? value)
  {
    openXmlElement.Shadow = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  private static Boolean? GetFrame(DXW.BorderType openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Frame);
  }
  
  private static bool CmpFrame(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Frame, value, diffs, objName, "Frame");
  }
  
  private static void SetFrame(DXW.BorderType openXmlElement, Boolean? value)
  {
    openXmlElement.Frame = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.BorderType? CreateModelElement(DXW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BorderType();
      value.Type = GetVal(openXmlElement);
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BorderType? openXmlElement, DMW.BorderType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      if (!CmpSpace(openXmlElement, value.Space, diffs, objName))
        ok = false;
      if (!CmpShadow(openXmlElement, value.Shadow, diffs, objName))
        ok = false;
      if (!CmpFrame(openXmlElement, value.Frame, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.BorderType value)
    where OpenXmlElementType: DXW.BorderType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.BorderType openXmlElement, DMW.BorderType value)
  {
    SetVal(openXmlElement, value?.Type);
    SetColor(openXmlElement, value?.Color);
    SetThemeColor(openXmlElement, value?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ThemeShade);
    SetSize(openXmlElement, value?.Size);
    SetSpace(openXmlElement, value?.Space);
    SetShadow(openXmlElement, value?.Shadow);
    SetFrame(openXmlElement, value?.Frame);
  }
}
