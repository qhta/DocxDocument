namespace DocumentModel.OpenXml.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public static class ScriptLinkConverter
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  private static String? GetVal(DXODrawY2021ScptLnk.ScriptLink openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXODrawY2021ScptLnk.ScriptLink openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDrawsOScptLnk.OfficeArtExtensionList? GetOfficeArtExtensionList(DXODrawY2021ScptLnk.ScriptLink openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXODrawY2021ScptLnk.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDrawsOScptLnk.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsOScptLnk.ScriptLink? CreateModelElement(DXODrawY2021ScptLnk.ScriptLink? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsOScptLnk.ScriptLink();
      value.Val = GetVal(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsOScptLnk.ScriptLink? value)
    where OpenXmlElementType: DXODrawY2021ScptLnk.ScriptLink, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
