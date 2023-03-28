namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ThemeFamily Class converter from/to OpenXml.
///</summary>
public static class ThemeFamilyConverter
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetName(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXO2013Theme.ThemeFamily openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetId(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2013Theme.ThemeFamily openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// vid, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetVid(DXO2013Theme.ThemeFamily openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Vid);
  }
  
  private static bool CmpVid(DXO2013Theme.ThemeFamily openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Vid, value, diffs, objName, "Vid");
  }
  
  private static void SetVid(DXO2013Theme.ThemeFamily openXmlElement, String? value)
  {
    openXmlElement.Vid = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DM.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013Theme.ThemeFamily openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013Theme.OfficeArtExtensionList>();
    if (element != null)
      return DMX.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013Theme.ThemeFamily openXmlElement, DM.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMX.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013Theme.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO2013Theme.ThemeFamily openXmlElement, DM.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013Theme.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013Theme.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.ThemeFamily? CreateModelElement(DXO2013Theme.ThemeFamily? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2013Theme.ThemeFamily? openXmlElement, DM.ThemeFamily? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpVid(openXmlElement, value.Vid, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ThemeFamily value)
    where OpenXmlElementType: DXO2013Theme.ThemeFamily, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2013Theme.ThemeFamily openXmlElement, DM.ThemeFamily value)
  {
    SetName(openXmlElement, value?.Name);
    SetId(openXmlElement, value?.Id);
    SetVid(openXmlElement, value?.Vid);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
