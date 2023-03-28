namespace DocumentModel.OpenXml.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class converter from/to OpenXml.
///</summary>
public static class ScriptLinkConverter
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetVal(DXODrawY2021ScptLnk.ScriptLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXODrawY2021ScptLnk.ScriptLink openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Normal");
  }
  
  private static void SetVal(DXODrawY2021ScptLnk.ScriptLink openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsOScptLnk.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODrawY2021ScptLnk.ScriptLink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODrawY2021ScptLnk.OfficeArtExtensionList>();
    if (element != null)
      return DMXDrawsOScptLnk.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXODrawY2021ScptLnk.ScriptLink openXmlElement, DMDrawsOScptLnk.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsOScptLnk.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODrawY2021ScptLnk.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXODrawY2021ScptLnk.ScriptLink openXmlElement, DMDrawsOScptLnk.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODrawY2021ScptLnk.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsOScptLnk.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXODrawY2021ScptLnk.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Office.ScriptLink.ScriptLink? CreateModelElement(DXODrawY2021ScptLnk.ScriptLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Office.ScriptLink.ScriptLink();
      value.Val = GetVal(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODrawY2021ScptLnk.ScriptLink? openXmlElement, DMDrawsOScptLnk.ScriptLink? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsOScptLnk.ScriptLink value)
    where OpenXmlElementType: DXODrawY2021ScptLnk.ScriptLink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODrawY2021ScptLnk.ScriptLink openXmlElement, DMDrawsOScptLnk.ScriptLink value)
  {
    SetVal(openXmlElement, value?.Val);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
