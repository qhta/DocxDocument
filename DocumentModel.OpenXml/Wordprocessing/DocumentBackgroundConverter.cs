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
    return openXmlElement?.Color?.Value;
  }
  
  private static bool CmpColor(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Color?.Value == value) return true;
    diffs?.Add(objName, "Color", openXmlElement?.Color?.Value, value);
    return false;
  }
  
  private static void SetColor(DXW.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Color = new StringValue { Value = value };
    else
      openXmlElement.Color = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues, DMW.ThemeColorKind>(openXmlElement?.ThemeColor?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.ThemeTint?.Value;
  }
  
  private static bool CmpThemeTint(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeTint?.Value == value) return true;
    diffs?.Add(objName, "ThemeTint", openXmlElement?.ThemeTint?.Value, value);
    return false;
  }
  
  private static void SetThemeTint(DXW.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeTint = new StringValue { Value = value };
    else
      openXmlElement.ThemeTint = null;
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  private static String? GetThemeShade(DXW.DocumentBackground openXmlElement)
  {
    return openXmlElement?.ThemeShade?.Value;
  }
  
  private static bool CmpThemeShade(DXW.DocumentBackground openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ThemeShade?.Value == value) return true;
    diffs?.Add(objName, "ThemeShade", openXmlElement?.ThemeShade?.Value, value);
    return false;
  }
  
  private static void SetThemeShade(DXW.DocumentBackground openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ThemeShade = new StringValue { Value = value };
    else
      openXmlElement.ThemeShade = null;
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  private static DMVml.Background? GetBackground(DXW.DocumentBackground openXmlElement)
  {
    return DMXVml.BackgroundConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXVml.Background>());
  }
  
  private static bool CmpBackground(DXW.DocumentBackground openXmlElement, DMVml.Background? value, DiffList? diffs, string? objName)
  {
    return DMXVml.BackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXVml.Background>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocumentBackground? value)
    where OpenXmlElementType: DXW.DocumentBackground, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColor(openXmlElement, value?.Color);
      SetThemeColor(openXmlElement, value?.ThemeColor);
      SetThemeTint(openXmlElement, value?.ThemeTint);
      SetThemeShade(openXmlElement, value?.ThemeShade);
      SetBackground(openXmlElement, value?.Background);
      return openXmlElement;
    }
    return default;
  }
}
