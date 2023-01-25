namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundRemovedProperties Class.
/// </summary>
public static class BackgroundRemovedPropertiesConverter
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDraws.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundRemovedProperties openXmlElement)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundRemovedProperties openXmlElement, DMDraws.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2021DrawLivefeed.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawLivefeed.BackgroundRemovedProperties openXmlElement, DMDraws.OfficeArtExtensionList? value)
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
  
  public static DMDraws.BackgroundRemovedProperties? CreateModelElement(DXO2021DrawLivefeed.BackgroundRemovedProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.BackgroundRemovedProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawLivefeed.BackgroundRemovedProperties? openXmlElement, DMDraws.BackgroundRemovedProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BackgroundRemovedProperties? value)
    where OpenXmlElementType: DXO2021DrawLivefeed.BackgroundRemovedProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
