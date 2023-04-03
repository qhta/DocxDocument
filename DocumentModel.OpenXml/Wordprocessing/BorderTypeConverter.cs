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
  private static RGB? GetColor(DXW.BorderType openXmlElement)
  {
    return ColorValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.BorderType openXmlElement, RGB? value, DiffList? diffs, string? objName)
  {
    return ColorValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXW.BorderType openXmlElement, RGB? value)
  {
    openXmlElement.Color = ColorValueConverter.CreateStringValue(value);
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
  private static BytePercent? GetThemeTint(DXW.BorderType openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.BorderType openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.BorderType openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeTint = BytePercentValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  private static BytePercent? GetThemeShade(DXW.BorderType openXmlElement)
  {
    return BytePercentValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.BorderType openXmlElement, BytePercent? value, DiffList? diffs, string? objName)
  {
    return BytePercentValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.BorderType openXmlElement, BytePercent? value)
  {
    openXmlElement.ThemeShade = BytePercentValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Border Width
  /// </summary>
  private static Twips? GetSize(DXW.BorderType openXmlElement)
  {
    if (openXmlElement?.Size?.Value!=null)
      return new Twips(openXmlElement.Size.Value*5);
    return null;
  }
  
  private static bool CmpSize(DXW.BorderType openXmlElement, Twips? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Size?.Value == value/5) return true;
    diffs?.Add(objName, "Width", openXmlElement?.Size?.Value, value);
    return false;
  }
  
  private static void SetSize(DXW.BorderType openXmlElement, Twips? value)
  {
    if (value is not null)
      openXmlElement.Size = ((uint)value)/5;
    else
      openXmlElement.Size = null;
  }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  private static Twips? GetSpace(DXW.BorderType openXmlElement)
  {
    if (openXmlElement?.Space?.Value!=null)
      return new Twips(openXmlElement.Space.Value*5);
    return null;
  }
  
  private static bool CmpSpace(DXW.BorderType openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Space?.Value == value/5) return true;
    diffs?.Add(objName, "Space", openXmlElement?.Space?.Value, value);
    return false;
  }
  
  private static void SetSpace(DXW.BorderType openXmlElement, UInt32? value)
  {
    if (value is not null)
      openXmlElement.Space = ((uint)value)/5;
    else
      openXmlElement.Space = null;
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
  
  public static DMW.Border? CreateModelElement(DXW.BorderType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Border();
      value.Type = GetVal(openXmlElement);
      var color = new DMW.Color();
      color.RGB = GetColor(openXmlElement);
      color.ThemeColor = GetThemeColor(openXmlElement);
      color.ThemeTint = GetThemeTint(openXmlElement);
      color.ThemeShade = GetThemeShade(openXmlElement);
      if (!color.IsEmpty())
        value.Color = color;
      value.Width = GetSize(openXmlElement);
      value.Space = GetSpace(openXmlElement);
      value.Shadow = GetShadow(openXmlElement);
      value.Frame = GetFrame(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BorderType? openXmlElement, DMW.Border? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpColor(openXmlElement, value.Color?.RGB, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.Color?.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.Color?.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.Color?.ThemeShade, diffs, objName))
        ok = false;
      if (!CmpSize(openXmlElement, value.Width, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Border value)
    where OpenXmlElementType: DXW.BorderType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.BorderType openXmlElement, DMW.Border value)
  {
    SetVal(openXmlElement, value?.Type);
    SetColor(openXmlElement, value?.Color?.RGB);
    SetThemeColor(openXmlElement, value?.Color?.ThemeColor);
    SetThemeTint(openXmlElement, value?.Color?.ThemeTint);
    SetThemeShade(openXmlElement, value?.Color?.ThemeShade);
    SetSize(openXmlElement, value?.Width);
    SetSpace(openXmlElement, value?.Space);
    SetShadow(openXmlElement, value?.Shadow);
    SetFrame(openXmlElement, value?.Frame);
  }
}
