namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Theme Override.
/// </summary>
public static class ThemeOverrideConverter
{
  /// <summary>
  /// Color Scheme.
  /// </summary>
  private static DMD.ColorScheme? GetColorScheme(DXD.ThemeOverride openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorScheme>();
    if (element != null)
      return DMXD.ColorSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorScheme(DXD.ThemeOverride openXmlElement, DMD.ColorScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ColorSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorScheme>(), value, diffs, objName, propName);
  }
  
  private static void SetColorScheme(DXD.ThemeOverride openXmlElement, DMD.ColorScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorSchemeConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FontScheme.
  /// </summary>
  private static DMD.FontScheme? GetFontScheme(DXD.ThemeOverride openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FontScheme>();
    if (element != null)
      return DMXD.FontSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontScheme(DXD.ThemeOverride openXmlElement, DMD.FontScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FontSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FontScheme>(), value, diffs, objName, propName);
  }
  
  private static void SetFontScheme(DXD.ThemeOverride openXmlElement, DMD.FontScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FontScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FontSchemeConverter.CreateOpenXmlElement<DXD.FontScheme>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// FormatScheme.
  /// </summary>
  private static DMD.FormatScheme? GetFormatScheme(DXD.ThemeOverride openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FormatScheme>();
    if (element != null)
      return DMXD.FormatSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormatScheme(DXD.ThemeOverride openXmlElement, DMD.FormatScheme? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.FormatSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FormatScheme>(), value, diffs, objName, propName);
  }
  
  private static void SetFormatScheme(DXD.ThemeOverride openXmlElement, DMD.FormatScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FormatScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FormatSchemeConverter.CreateOpenXmlElement<DXD.FormatScheme>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ThemeOverride? CreateModelElement(DXD.ThemeOverride? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ThemeOverride();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ThemeOverride? openXmlElement, DMD.ThemeOverride? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpColorScheme(openXmlElement, value.ColorScheme, diffs, objName, propName))
        ok = false;
      if (!CmpFontScheme(openXmlElement, value.FontScheme, diffs, objName, propName))
        ok = false;
      if (!CmpFormatScheme(openXmlElement, value.FormatScheme, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ThemeOverride value)
    where OpenXmlElementType: DXD.ThemeOverride, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ThemeOverride openXmlElement, DMD.ThemeOverride value)
  {
    SetColorScheme(openXmlElement, value?.ColorScheme);
    SetFontScheme(openXmlElement, value?.FontScheme);
    SetFormatScheme(openXmlElement, value?.FormatScheme);
  }
}
