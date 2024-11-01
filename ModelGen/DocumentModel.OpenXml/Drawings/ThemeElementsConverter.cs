namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public static class ThemeElementsConverter
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  private static DMDraws.ColorScheme? GetColorScheme(DXDraw.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ColorScheme>();
    if (element != null)
      return DMXDraws.ColorSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpColorScheme(DXDraw.ThemeElements openXmlElement, DMDraws.ColorScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ColorSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ColorScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetColorScheme(DXDraw.ThemeElements openXmlElement, DMDraws.ColorScheme? value)
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
  /// Font Scheme.
  /// </summary>
  private static DMDraws.FontScheme? GetFontScheme(DXDraw.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FontScheme>();
    if (element != null)
      return DMXDraws.FontSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FontScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FontSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FontScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FontScheme? value)
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
  /// Format Scheme.
  /// </summary>
  private static DMDraws.FormatScheme? GetFormatScheme(DXDraw.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.FormatScheme>();
    if (element != null)
      return DMXDraws.FormatSchemeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormatScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FormatScheme? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.FormatSchemeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.FormatScheme>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormatScheme(DXDraw.ThemeElements openXmlElement, DMDraws.FormatScheme? value)
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
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDraws.ExtensionList? GetExtensionList(DXDraw.ThemeElements openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ExtensionList>();
    if (element != null)
      return DMXDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXDraw.ThemeElements openXmlElement, DMDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXDraw.ThemeElements openXmlElement, DMDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ExtensionListConverter.CreateOpenXmlElement<DXDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ThemeElements? CreateModelElement(DXDraw.ThemeElements? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.ThemeElements? openXmlElement, DMDraws.ThemeElements? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.ThemeElements value)
    where OpenXmlElementType: DXDraw.ThemeElements, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.ThemeElements openXmlElement, DMDraws.ThemeElements value)
  {
    SetColorScheme(openXmlElement, value?.ColorScheme);
    SetFontScheme(openXmlElement, value?.FontScheme);
    SetFormatScheme(openXmlElement, value?.FormatScheme);
    SetExtensionList(openXmlElement, value?.ExtensionList);
  }
}
