namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public static class OfficeStyleSheetExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXD.OfficeStyleSheetExtension openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Uri);
  }
  
  private static bool CmpUri(DXD.OfficeStyleSheetExtension openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Uri, value, diffs, objName, "Uri");
  }
  
  private static void SetUri(DXD.OfficeStyleSheetExtension openXmlElement, String? value)
  {
    openXmlElement.Uri = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.ThemeFamily? GetThemeFamily(DXD.OfficeStyleSheetExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13T.ThemeFamily>();
    if (element != null)
      return DMX.ThemeFamilyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpThemeFamily(DXD.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ThemeFamilyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13T.ThemeFamily>(), value, diffs, objName, propName);
  }
  
  private static void SetThemeFamily(DXD.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13T.ThemeFamily>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ThemeFamilyConverter.CreateOpenXmlElement<DXO13T.ThemeFamily>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.OfficeStyleSheetExtension? CreateModelElement(DXD.OfficeStyleSheetExtension? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.OfficeStyleSheetExtension? openXmlElement, DMD.OfficeStyleSheetExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName, propName))
        ok = false;
      if (!CmpThemeFamily(openXmlElement, value.ThemeFamily, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.OfficeStyleSheetExtension value)
    where OpenXmlElementType: DXD.OfficeStyleSheetExtension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.OfficeStyleSheetExtension openXmlElement, DMD.OfficeStyleSheetExtension value)
  {
    SetUri(openXmlElement, value?.Uri);
    SetThemeFamily(openXmlElement, value?.ThemeFamily);
  }
}
