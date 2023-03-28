namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundBlurProperties Class converter from/to OpenXml.
///</summary>
public static class BackgroundBlurPropertiesConverter
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundBlurProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (element != null)
      return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundBlurProperties openXmlElement, DMDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundBlurProperties openXmlElement, DMDraws.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.BackgroundBlurProperties? CreateModelElement(DXO2021DrawLivefeed.BackgroundBlurProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundBlurProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawLivefeed.BackgroundBlurProperties? openXmlElement, DMDraws.BackgroundBlurProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundBlurProperties value)
    where OpenXmlElementType: DXO2021DrawLivefeed.BackgroundBlurProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DrawLivefeed.BackgroundBlurProperties openXmlElement, DMDraws.BackgroundBlurProperties value)
  {
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
