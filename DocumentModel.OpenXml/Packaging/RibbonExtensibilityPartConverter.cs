namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the RibbonExtensibilityPart
/// </summary>
public static class RibbonExtensibilityPartConverter
{
  private static String? GetContentType(DXPack.RibbonExtensibilityPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonExtensibilityPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.RibbonExtensibilityPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.RibbonExtensibilityPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.RibbonExtensibilityPart? CreateModelElement(DXPack.RibbonExtensibilityPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.RibbonExtensibilityPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.RibbonExtensibilityPart? value)
    where OpenXmlElementType: DXPack.RibbonExtensibilityPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
