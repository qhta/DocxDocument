namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public static class ThemeOverrideConverter
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  private static DMDraws.ColorScheme? GetColorScheme(DXDraw.ThemeOverride openXmlElement)
  {
    return DMXDraws.ColorSchemeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorScheme>());
  }
  
  private static bool CmpColorScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.ColorScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorSchemeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.ColorScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.ColorScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ColorScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ColorSchemeConverter.CreateOpenXmlElement<DXDraw.ColorScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  private static DMDraws.FontScheme? GetFontScheme(DXDraw.ThemeOverride openXmlElement)
  {
    return DMXDraws.FontSchemeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FontScheme>());
  }
  
  private static bool CmpFontScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FontScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FontSchemeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.FontScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FontScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FontScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FontSchemeConverter.CreateOpenXmlElement<DXDraw.FontScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  private static DMDraws.FormatScheme? GetFormatScheme(DXDraw.ThemeOverride openXmlElement)
  {
    return DMXDraws.FormatSchemeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.FormatScheme>());
  }
  
  private static bool CmpFormatScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FormatScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FormatSchemeConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.FormatScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormatScheme(DXDraw.ThemeOverride openXmlElement, DMDraws.FormatScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.FormatScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.FormatSchemeConverter.CreateOpenXmlElement<DXDraw.FormatScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.ThemeOverride? CreateModelElement(DXDraw.ThemeOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.ThemeOverride();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.ThemeOverride? openXmlElement, DMDraws.ThemeOverride? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorScheme(openXmlElement, value.ColorScheme, diffs, objName))
        ok = false;
      if (!CmpFontScheme(openXmlElement, value.FontScheme, diffs, objName))
        ok = false;
      if (!CmpFormatScheme(openXmlElement, value.FormatScheme, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ThemeOverride? value)
    where OpenXmlElementType: DXDraw.ThemeOverride, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorScheme(openXmlElement, value?.ColorScheme);
      SetFontScheme(openXmlElement, value?.FontScheme);
      SetFormatScheme(openXmlElement, value?.FormatScheme);
      return openXmlElement;
    }
    return default;
  }
}
