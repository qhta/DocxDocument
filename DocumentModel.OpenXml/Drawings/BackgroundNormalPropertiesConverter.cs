namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BackgroundNormalProperties Class.
/// </summary>
public static class BackgroundNormalPropertiesConverter
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMD.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO21DL.BackgroundNormalProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DL.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO21DL.BackgroundNormalProperties openXmlElement, DMD.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXD.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DL.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO21DL.BackgroundNormalProperties openXmlElement, DMD.OfficeArtExtensionList? value)
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
  
  public static DocumentModel.Drawings.BackgroundNormalProperties? CreateModelElement(DXO21DL.BackgroundNormalProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BackgroundNormalProperties();
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO21DL.BackgroundNormalProperties? openXmlElement, DMD.BackgroundNormalProperties? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BackgroundNormalProperties value)
    where OpenXmlElementType: DXO21DL.BackgroundNormalProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DL.BackgroundNormalProperties openXmlElement, DMD.BackgroundNormalProperties value)
  {
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
