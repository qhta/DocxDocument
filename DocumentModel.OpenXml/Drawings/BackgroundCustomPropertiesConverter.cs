namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
public static class BackgroundCustomPropertiesConverter
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundCustomProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>();
    if (element != null)
      return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundCustomProperties openXmlElement, DMDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundCustomProperties openXmlElement, DMDraws.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.BackgroundCustomProperties? CreateModelElement(DXO2021DrawLivefeed.BackgroundCustomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundCustomProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawLivefeed.BackgroundCustomProperties? openXmlElement, DMDraws.BackgroundCustomProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundCustomProperties value)
    where OpenXmlElementType: DXO2021DrawLivefeed.BackgroundCustomProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2021DrawLivefeed.BackgroundCustomProperties openXmlElement, DMDraws.BackgroundCustomProperties value)
  {
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
