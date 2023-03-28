namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public static class DocumentBackgroundConverter
{
  /// <summary>
  /// color
  /// </summary>
  private static String? GetColor(DXW.DocumentBackground openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Color);
  }
  
  private static bool CmpColor(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Color, value, diffs, objName, "Color");
  }
  
  private static void SetColor(DXW.DocumentBackground openXmlElement, String? value)
  {
    openXmlElement.Color = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// themeColor
  /// </summary>
  private static DMW.ThemeColorKind? GetThemeColor(DXW.DocumentBackground openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value);
  }
  
  private static bool CmpThemeColor(DXW.DocumentBackground openXmlElement, DMW.ThemeColorKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName);
  }
  
  private static void SetThemeColor(DXW.DocumentBackground openXmlElement, DMW.ThemeColorKind? value)
  {
    openXmlElement.ThemeColor = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(value);
  }
  
  /// <summary>
  /// themeTint
  /// </summary>
  private static String? GetThemeTint(DXW.DocumentBackground openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeTint);
  }
  
  private static bool CmpThemeTint(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeTint, value, diffs, objName, "ThemeTint");
  }
  
  private static void SetThemeTint(DXW.DocumentBackground openXmlElement, String? value)
  {
    openXmlElement.ThemeTint = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  private static String? GetThemeShade(DXW.DocumentBackground openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ThemeShade);
  }
  
  private static bool CmpThemeShade(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ThemeShade, value, diffs, objName, "ThemeShade");
  }
  
  private static void SetThemeShade(DXW.DocumentBackground openXmlElement, String? value)
  {
    openXmlElement.ThemeShade = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  private static DMVml.Background? GetBackground(DXW.DocumentBackground openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXVml.Background>();
    if (element != null)
      return DMXVml.BackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackground(DXW.DocumentBackground openXmlElement, DMVml.Background? value, DiffList? diffs, string? objName)
  {
    return DMXVml.BackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Background>(), value, diffs, objName);
  }
  
  private static void SetBackground(DXW.DocumentBackground openXmlElement, DMVml.Background? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXVml.Background>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXVml.BackgroundConverter.CreateOpenXmlElement<DXVml.Background>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DocumentBackground? CreateModelElement(DXW.DocumentBackground? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocumentBackground();
      value.Color = GetColor(openXmlElement);
      value.ThemeColor = GetThemeColor(openXmlElement);
      value.ThemeTint = GetThemeTint(openXmlElement);
      value.ThemeShade = GetThemeShade(openXmlElement);
      value.Background = GetBackground(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocumentBackground? openXmlElement, DMW.DocumentBackground? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColor(openXmlElement, value.Color, diffs, objName))
        ok = false;
      if (!CmpThemeColor(openXmlElement, value.ThemeColor, diffs, objName))
        ok = false;
      if (!CmpThemeTint(openXmlElement, value.ThemeTint, diffs, objName))
        ok = false;
      if (!CmpThemeShade(openXmlElement, value.ThemeShade, diffs, objName))
        ok = false;
      if (!CmpBackground(openXmlElement, value.Background, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentBackground value)
    where OpenXmlElementType: DXW.DocumentBackground, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocumentBackground openXmlElement, DMW.DocumentBackground value)
  {
    SetColor(openXmlElement, value?.Color);
    SetThemeColor(openXmlElement, value?.ThemeColor);
    SetThemeTint(openXmlElement, value?.ThemeTint);
    SetThemeShade(openXmlElement, value?.ThemeShade);
    SetBackground(openXmlElement, value?.Background);
  }
}
