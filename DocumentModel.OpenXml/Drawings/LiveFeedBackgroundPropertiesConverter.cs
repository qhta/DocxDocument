namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public static class LiveFeedBackgroundPropertiesConverter
{
  private static DMDraws.BackgroundNormalProperties? GetBackgroundNormalProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundNormalProperties>();
    if (itemElement != null)
      return DMXDraws.BackgroundNormalPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundNormalProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundNormalProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundNormalProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundNormalPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.BackgroundNormalProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BackgroundRemovedProperties? GetBackgroundRemovedProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundRemovedProperties>();
    if (itemElement != null)
      return DMXDraws.BackgroundRemovedPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundRemovedProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundRemovedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundRemovedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundRemovedPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.BackgroundRemovedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BackgroundBlurProperties? GetBackgroundBlurProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundBlurProperties>();
    if (itemElement != null)
      return DMXDraws.BackgroundBlurPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundBlurProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundBlurProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundBlurProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundBlurPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.BackgroundBlurProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.BackgroundCustomProperties? GetBackgroundCustomProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundCustomProperties>();
    if (itemElement != null)
      return DMXDraws.BackgroundCustomPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundCustomProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundCustomProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundCustomProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundCustomPropertiesConverter.CreateOpenXmlElement<DXO2021DrawLivefeed.BackgroundCustomProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (itemElement != null)
      return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.OfficeArtExtensionList? value)
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
  
  public static DMDraws.LiveFeedBackgroundProperties? CreateModelElement(DXO2021DrawLivefeed.LiveFeedBackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LiveFeedBackgroundProperties();
      value.BackgroundNormalProperties = GetBackgroundNormalProperties(openXmlElement);
      value.BackgroundRemovedProperties = GetBackgroundRemovedProperties(openXmlElement);
      value.BackgroundBlurProperties = GetBackgroundBlurProperties(openXmlElement);
      value.BackgroundCustomProperties = GetBackgroundCustomProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LiveFeedBackgroundProperties? value)
    where OpenXmlElementType: DXO2021DrawLivefeed.LiveFeedBackgroundProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackgroundNormalProperties(openXmlElement, value?.BackgroundNormalProperties);
      SetBackgroundRemovedProperties(openXmlElement, value?.BackgroundRemovedProperties);
      SetBackgroundBlurProperties(openXmlElement, value?.BackgroundBlurProperties);
      SetBackgroundCustomProperties(openXmlElement, value?.BackgroundCustomProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
