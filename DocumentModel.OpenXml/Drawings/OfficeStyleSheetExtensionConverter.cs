namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the OfficeStyleSheetExtension Class.
/// </summary>
public static class OfficeStyleSheetExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDraw.OfficeStyleSheetExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDraw.OfficeStyleSheetExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DM.ThemeFamily? GetThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement)
  {
    return DMX.ThemeFamilyConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013Theme.ThemeFamily>());
  }
  
  private static bool CmpThemeFamily(DXDraw.OfficeStyleSheetExtension openXmlElement, DM.ThemeFamily? value, DiffList? diffs, string? objName)
  {
    return DMX.ThemeFamilyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Theme.ThemeFamily>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMDraws.OfficeStyleSheetExtension? CreateModelElement(DXDraw.OfficeStyleSheetExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.OfficeStyleSheetExtension();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.OfficeStyleSheetExtension? value)
    where OpenXmlElementType: DXDraw.OfficeStyleSheetExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetThemeFamily(openXmlElement, value?.ThemeFamily);
      return openXmlElement;
    }
    return default;
  }
}
