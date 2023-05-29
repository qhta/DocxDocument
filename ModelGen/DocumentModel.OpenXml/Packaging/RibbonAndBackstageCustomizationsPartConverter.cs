namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public static class RibbonAndBackstageCustomizationsPartConverter
{
  private static String? GetContentType(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.CustomUI? GetCustomUI(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
      return DMX.CustomUIConverter.CreateModelElement(openXmlElement?.RootElement as DXO2010CustUI.CustomUI);
  }
  
  private static bool CmpCustomUI(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, DM.CustomUI? value, DiffList? diffs, string? objName)
  {
      return true;
  }
  
  private static void SetCustomUI(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, DM.CustomUI? value)
  {
    if (value != null)
    {
       var rootElement = DMX.CustomUIConverter.CreateOpenXmlElement<DXO2010CustUI.CustomUI>(value);
       if (rootElement != null)
         openXmlElement.CustomUI = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    var collection = new Collection<DMPack.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.ImagePart>())
    {
      var newItem = DMXPack.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpImageParts(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? CreateModelElement(DXPack.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.CustomUI = GetCustomUI(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.RibbonAndBackstageCustomizationsPart? openXmlElement, DMPack.RibbonAndBackstageCustomizationsPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpCustomUI(openXmlElement, value.CustomUI, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.RibbonAndBackstageCustomizationsPart value)
    where OpenXmlElementType: DXPack.RibbonAndBackstageCustomizationsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement, DMPack.RibbonAndBackstageCustomizationsPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    SetCustomUI(openXmlElement, value?.CustomUI);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
