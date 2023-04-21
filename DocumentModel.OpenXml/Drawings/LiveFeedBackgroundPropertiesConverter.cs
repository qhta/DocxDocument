namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LiveFeedBackgroundProperties Class.
/// </summary>
public static class LiveFeedBackgroundPropertiesConverter
{
  private static DMD.BackgroundNormalProperties? GetBackgroundNormalProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.BackgroundNormalProperties>();
    if (element != null)
      return DMXD.BackgroundNormalPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundNormalProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundNormalProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundNormalPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.BackgroundNormalProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundNormalProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundNormalProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.BackgroundNormalProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundNormalPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundNormalProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BackgroundRemovedProperties? GetBackgroundRemovedProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.BackgroundRemovedProperties>();
    if (element != null)
      return DMXD.BackgroundRemovedPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundRemovedProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundRemovedProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundRemovedPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.BackgroundRemovedProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundRemovedProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundRemovedProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.BackgroundRemovedProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundRemovedPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundRemovedProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BackgroundBlurProperties? GetBackgroundBlurProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.BackgroundBlurProperties>();
    if (element != null)
      return DMXD.BackgroundBlurPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundBlurProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundBlurProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundBlurPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.BackgroundBlurProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundBlurProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundBlurProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.BackgroundBlurProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundBlurPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundBlurProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.BackgroundCustomProperties? GetBackgroundCustomProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.BackgroundCustomProperties>();
    if (element != null)
      return DMXD.BackgroundCustomPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundCustomProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundCustomProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.BackgroundCustomPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.BackgroundCustomProperties>(), value, diffs, objName);
  }
  
  private static void SetBackgroundCustomProperties(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.BackgroundCustomProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.BackgroundCustomProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundCustomPropertiesConverter.CreateOpenXmlElement<DXO21DL.BackgroundCustomProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMD.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO21DL.LiveFeedBackgroundProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO21DL.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LiveFeedBackgroundProperties? CreateModelElement(DXO21DL.LiveFeedBackgroundProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LiveFeedBackgroundProperties();
      value.BackgroundNormalProperties = GetBackgroundNormalProperties(openXmlElement);
      value.BackgroundRemovedProperties = GetBackgroundRemovedProperties(openXmlElement);
      value.BackgroundBlurProperties = GetBackgroundBlurProperties(openXmlElement);
      value.BackgroundCustomProperties = GetBackgroundCustomProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DL.LiveFeedBackgroundProperties? openXmlElement, DMD.LiveFeedBackgroundProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LiveFeedBackgroundProperties value)
    where OpenXmlElementType: DXO21DL.LiveFeedBackgroundProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DL.LiveFeedBackgroundProperties openXmlElement, DMD.LiveFeedBackgroundProperties value)
  {
    SetBackgroundNormalProperties(openXmlElement, value?.BackgroundNormalProperties);
    SetBackgroundRemovedProperties(openXmlElement, value?.BackgroundRemovedProperties);
    SetBackgroundBlurProperties(openXmlElement, value?.BackgroundBlurProperties);
    SetBackgroundCustomProperties(openXmlElement, value?.BackgroundCustomProperties);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
