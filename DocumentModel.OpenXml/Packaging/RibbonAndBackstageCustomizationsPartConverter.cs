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
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DM.CustomUI? GetCustomUI(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2010CustUI.CustomUI rootElement)
      return DMX.CustomUIConverter.CreateModelElement(rootElement);
    return null;
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
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.RibbonAndBackstageCustomizationsPart? CreateModelElement(DXPack.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.RibbonAndBackstageCustomizationsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.CustomUI = GetCustomUI(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.RibbonAndBackstageCustomizationsPart? value)
    where OpenXmlElementType: DXPack.RibbonAndBackstageCustomizationsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetCustomUI(openXmlElement, value?.CustomUI);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
