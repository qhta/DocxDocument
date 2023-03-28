namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class converter from/to OpenXml.
///</summary>
public static class OfficeStyleSheetExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXDraw.OfficeStyleSheetExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXDraw.OfficeStyleSheetExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.ThemeFamily? GetThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013Theme.ThemeFamily>();
    if (element != null)
      return DMX.ThemeFamilyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value, DiffList? diffs, string? objName)
  {
    return DMX.ThemeFamilyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Theme.ThemeFamily>(), value, diffs, objName);
  }
  
  private static void SetThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Theme.ThemeFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ThemeFamilyConverter.CreateOpenXmlElement<DXO2013Theme.ThemeFamily>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.OfficeStyleSheetExtension? CreateModelElement(DXDraw.OfficeStyleSheetExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.OfficeStyleSheetExtension();
      value.Uri = GetUri(openXmlElement);
      value.ThemeFamily = GetThemeFamily(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.OfficeStyleSheetExtension? openXmlElement, DMDraws.OfficeStyleSheetExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpThemeFamily(openXmlElement, value.ThemeFamily, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeStyleSheetExtension value)
    where OpenXmlElementType: DXDraw.OfficeStyleSheetExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.OfficeStyleSheetExtension openXmlElement, DMDraws.OfficeStyleSheetExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetThemeFamily(openXmlElement, value?.ThemeFamily);
  }
}
