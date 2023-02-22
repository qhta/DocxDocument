namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public static class LiveFeedPropertiesConverter
{
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  private static DMDraws.LiveFeedBackgroundProperties? GetLiveFeedBackgroundProperties(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedBackgroundProperties>();
    if (element != null)
      return DMXDraws.LiveFeedBackgroundPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLiveFeedBackgroundProperties(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement, DMDraws.LiveFeedBackgroundProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LiveFeedBackgroundPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.LiveFeedBackgroundProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLiveFeedBackgroundProperties(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement, DMDraws.LiveFeedBackgroundProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.LiveFeedBackgroundProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LiveFeedBackgroundPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.LiveFeedBackgroundProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (element != null)
      return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement, DMDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement, DMDraws.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LiveFeedProperties? CreateModelElement(DXO2021DrawLivefeed.LiveFeedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LiveFeedProperties();
      value.LiveFeedBackgroundProperties = GetLiveFeedBackgroundProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawLivefeed.LiveFeedProperties? openXmlElement, DMDraws.LiveFeedProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLiveFeedBackgroundProperties(openXmlElement, value.LiveFeedBackgroundProperties, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LiveFeedProperties value)
    where OpenXmlElementType: DXO2021DrawLivefeed.LiveFeedProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DrawLivefeed.LiveFeedProperties openXmlElement, DMDraws.LiveFeedProperties value)
  {
    SetLiveFeedBackgroundProperties(openXmlElement, value?.LiveFeedBackgroundProperties);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
    }
  }
