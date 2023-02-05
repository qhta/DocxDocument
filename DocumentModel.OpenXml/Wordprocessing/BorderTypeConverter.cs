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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.BorderValues, DMW.BorderKind>(openXmlElement?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.Color?.Value;
  }
  
  private static bool CmpColor(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color?.Value == value) return true;
    diffs?.Add(objName, "Color", openXmlElement?.Color?.Value, value);
    return false;
  }
  
  private static void SetColor(DXW.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static bool CmpThemeTint(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeTint?.Value == value) return true;
    diffs?.Add(objName, "ThemeTint", openXmlElement?.ThemeTint?.Value, value);
    return false;
  }
  
  private static void SetThemeTint(DXW.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  private static String? GetThemeShade(DXW.BorderType openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static bool CmpThemeShade(DXW.BorderType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeShade?.Value == value) return true;
    diffs?.Add(objName, "ThemeShade", openXmlElement?.ThemeShade?.Value, value);
    return false;
  }
  
  private static void SetThemeShade(DXW.BorderType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
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
    return openXmlElement?.Shadow?.Value;
  }
  
  private static bool CmpShadow(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Shadow?.Value == value) return true;
    diffs?.Add(objName, "Shadow", openXmlElement?.Shadow?.Value, value);
    return false;
  }
  
  private static void SetShadow(DXW.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Shadow = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Shadow = null;
  }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  private static Boolean? GetFrame(DXW.BorderType openXmlElement)
  {
    return openXmlElement?.Frame?.Value;
  }
  
  private static bool CmpFrame(DXW.BorderType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Frame?.Value == value) return true;
    diffs?.Add(objName, "Frame", openXmlElement?.Frame?.Value, value);
    return false;
  }
  
  private static void SetFrame(DXW.BorderType openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Frame = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Frame = null;
  }
  
  public static DMW.BorderType? CreateModelElement(DXW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BorderType();
      value.Val = GetVal(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.BorderType? value)
    where OpenXmlElementType: DXW.BorderType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetSize(openXmlElement, value?.Size);
      SetSpace(openXmlElement, value?.Space);
      SetShadow(openXmlElement, value?.Shadow);
      SetFrame(openXmlElement, value?.Frame);
      return openXmlElement;
    }
    return default;
  }
}
