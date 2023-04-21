namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public static class ThemeElementsConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DMD.ColorScheme? GetColorScheme(DXD.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ColorScheme>();
    if (element != null)
      return DMXD.ColorSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorScheme(DXD.ThemeElements openXmlElement, DMD.ColorScheme? value, DiffList? diffs, string? objName)
  {
    return DMXD.ColorSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ColorScheme>(), value, diffs, objName);
  }
  
  private static void SetColorScheme(DXD.ThemeElements openXmlElement, DMD.ColorScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ColorScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ColorSchemeConverter.CreateOpenXmlElement<DXD.ColorScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  private static DMD.FontScheme? GetFontScheme(DXD.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FontScheme>();
    if (element != null)
      return DMXD.FontSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontScheme(DXD.ThemeElements openXmlElement, DMD.FontScheme? value, DiffList? diffs, string? objName)
  {
    return DMXD.FontSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FontScheme>(), value, diffs, objName);
  }
  
  private static void SetFontScheme(DXD.ThemeElements openXmlElement, DMD.FontScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FontScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FontSchemeConverter.CreateOpenXmlElement<DXD.FontScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  private static DMD.FormatScheme? GetFormatScheme(DXD.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.FormatScheme>();
    if (element != null)
      return DMXD.FormatSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormatScheme(DXD.ThemeElements openXmlElement, DMD.FormatScheme? value, DiffList? diffs, string? objName)
  {
    return DMXD.FormatSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.FormatScheme>(), value, diffs, objName);
  }
  
  private static void SetFormatScheme(DXD.ThemeElements openXmlElement, DMD.FormatScheme? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.FormatScheme>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.FormatSchemeConverter.CreateOpenXmlElement<DXD.FormatScheme>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMD.ExtensionList? GetExtensionList(DXD.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ExtensionList>();
    if (element != null)
      return DMXD.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXD.ThemeElements openXmlElement, DMD.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ExtensionList>(), value, diffs, objName);
  }
  
  private static void SetExtensionList(DXD.ThemeElements openXmlElement, DMD.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ThemeElements? CreateModelElement(DXD.ThemeElements? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ThemeElements();
      value.ColorScheme = GetColorScheme(openXmlElement);
      value.FontScheme = GetFontScheme(openXmlElement);
      value.FormatScheme = GetFormatScheme(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.ThemeElements? openXmlElement, DMD.ThemeElements? value, DiffList? diffs, string? objName)
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
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.ThemeElements value)
    where OpenXmlElementType: DXD.ThemeElements, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.ThemeElements openXmlElement, DMD.ThemeElements value)
  {
    SetColorScheme(openXmlElement, value?.ColorScheme);
    SetFontScheme(openXmlElement, value?.FontScheme);
    SetFormatScheme(openXmlElement, value?.FormatScheme);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
