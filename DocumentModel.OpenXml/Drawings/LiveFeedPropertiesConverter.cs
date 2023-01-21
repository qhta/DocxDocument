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
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.LiveFeedBackgroundProperties>();
    if (itemElement != null)
      return DMXDraws.LiveFeedBackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.LiveFeedProperties? CreateModelElement(DXO2021DrawLivefeed.LiveFeedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LiveFeedProperties();
      value.LiveFeedBackgroundProperties = GetLiveFeedBackgroundProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LiveFeedProperties? value)
    where OpenXmlElementType: DXO2021DrawLivefeed.LiveFeedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLiveFeedBackgroundProperties(openXmlElement, value?.LiveFeedBackgroundProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
