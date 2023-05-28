namespace DocumentModel.OpenXml.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public static class ScriptLinkConverter
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetVal(DXODY21SL.ScriptLink openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Val);
  }
  
  private static bool CmpVal(DXODY21SL.ScriptLink openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Val, value, diffs, objName, "Value");
  }
  
  private static void SetVal(DXODY21SL.ScriptLink openXmlElement, String? value)
  {
    openXmlElement.Val = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDOSL.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODY21SL.ScriptLink openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXODY21SL.OfficeArtExtensionList>();
    if (element != null)
      return DMXDOScptLnk.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXODY21SL.ScriptLink openXmlElement, DMDOSL.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDOScptLnk.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXODY21SL.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXODY21SL.ScriptLink openXmlElement, DMDOSL.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXODY21SL.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDOScptLnk.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXODY21SL.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDO.ScriptLink.ScriptLink? CreateModelElement(DXODY21SL.ScriptLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDO.ScriptLink.ScriptLink();
      value.Val = GetVal(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXODY21SL.ScriptLink? openXmlElement, DMDOSL.ScriptLink? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVal(openXmlElement, value.Val, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDOSL.ScriptLink value)
    where OpenXmlElementType: DXODY21SL.ScriptLink, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXODY21SL.ScriptLink openXmlElement, DMDOSL.ScriptLink value)
  {
    SetVal(openXmlElement, value?.Val);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
