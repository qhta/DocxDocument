namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ThemeFamily Class.
/// </summary>
public static class ThemeFamilyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DXO13T.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO13T.ThemeFamily openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO13T.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO13T.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO13T.ThemeFamily openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO13T.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVid(DXO13T.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Vid);
  }
  
  private static bool CmpVid(DXO13T.ThemeFamily openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Vid, value, diffs, objName, "Vid");
  }
  
  private static void SetVid(DXO13T.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Vid = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DM.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13T.ThemeFamily openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13T.OfficeArtExtensionList>();
    if (element != null)
      return DMX.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13T.ThemeFamily openXmlElement, DM.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13T.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13T.ThemeFamily openXmlElement, DM.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13T.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13T.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.ThemeFamily? CreateModelElement(DXO13T.ThemeFamily? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ThemeFamily();
      value.Name = GetName(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Vid = GetVid(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO13T.ThemeFamily? openXmlElement, DM.ThemeFamily? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpVid(openXmlElement, value.Vid, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ThemeFamily value)
    where OpenXmlElementType: DXO13T.ThemeFamily, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13T.ThemeFamily openXmlElement, DM.ThemeFamily value)
  {
    SetName(openXmlElement, value?.Name);
    SetId(openXmlElement, value?.Id);
    SetVid(openXmlElement, value?.Vid);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
