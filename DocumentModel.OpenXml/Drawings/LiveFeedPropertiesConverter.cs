namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public static class LiveFeedPropertiesConverter
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  private static DMD.LiveFeedBackgroundProperties? GetLiveFeedBackgroundProperties(DXO21DL.LiveFeedProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.LiveFeedBackgroundProperties>();
    if (element != null)
      return DMXD.LiveFeedBackgroundPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLiveFeedBackgroundProperties(DXO21DL.LiveFeedProperties openXmlElement, DMD.LiveFeedBackgroundProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.LiveFeedBackgroundPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.LiveFeedBackgroundProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetLiveFeedBackgroundProperties(DXO21DL.LiveFeedProperties openXmlElement, DMD.LiveFeedBackgroundProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.LiveFeedBackgroundProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LiveFeedBackgroundPropertiesConverter.CreateOpenXmlElement<DXO21DL.LiveFeedBackgroundProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMD.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO21DL.LiveFeedProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO21DL.LiveFeedProperties openXmlElement, DMD.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXO21DL.LiveFeedProperties openXmlElement, DMD.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO21DL.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.LiveFeedProperties? CreateModelElement(DXO21DL.LiveFeedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.LiveFeedProperties();
      value.LiveFeedBackgroundProperties = GetLiveFeedBackgroundProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DL.LiveFeedProperties? openXmlElement, DMD.LiveFeedProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLiveFeedBackgroundProperties(openXmlElement, value.LiveFeedBackgroundProperties, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LiveFeedProperties value)
    where OpenXmlElementType: DXO21DL.LiveFeedProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DL.LiveFeedProperties openXmlElement, DMD.LiveFeedProperties value)
  {
    SetLiveFeedBackgroundProperties(openXmlElement, value?.LiveFeedBackgroundProperties);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
