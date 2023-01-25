namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public static class LiveFeedBackgroundPropertiesConverter
{
  private static DMDraws.BackgroundNormalProperties? GetBackgroundNormalProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement)
  {
    return DMXDraws.BackgroundNormalPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundNormalProperties>());
  }
  
  private static bool CmpBackgroundNormalProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundNormalProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundNormalPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundNormalProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.BackgroundRemovedPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundRemovedProperties>());
  }
  
  private static bool CmpBackgroundRemovedProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundRemovedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundRemovedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundRemovedProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.BackgroundBlurPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundBlurProperties>());
  }
  
  private static bool CmpBackgroundBlurProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundBlurProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundBlurPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundBlurProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.BackgroundCustomPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.BackgroundCustomProperties>());
  }
  
  private static bool CmpBackgroundCustomProperties(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.BackgroundCustomProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundCustomPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.BackgroundCustomProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawLivefeed.LiveFeedBackgroundProperties openXmlElement, DMDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2021DrawLivefeed.LiveFeedBackgroundProperties? openXmlElement, DMDraws.LiveFeedBackgroundProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBackgroundNormalProperties(openXmlElement, value.BackgroundNormalProperties, diffs, objName))
        ok = false;
      if (!CmpBackgroundRemovedProperties(openXmlElement, value.BackgroundRemovedProperties, diffs, objName))
        ok = false;
      if (!CmpBackgroundBlurProperties(openXmlElement, value.BackgroundBlurProperties, diffs, objName))
        ok = false;
      if (!CmpBackgroundCustomProperties(openXmlElement, value.BackgroundCustomProperties, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
