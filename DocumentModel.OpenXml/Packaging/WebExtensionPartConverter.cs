namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public static class WebExtensionPartConverter
{
  private static String? GetContentType(DXPack.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  private static Collection<DMPack.ImagePart> GetImageParts(DXPack.WebExtensionPart openXmlElement)
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
  
  private static String? GetRelationshipType(DXPack.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMWebExt.WebExtension? GetWebExtension(DXPack.WebExtensionPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013WebExt.WebExtension rootElement)
      return DMXWebExt.WebExtensionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetWebExtension(DXPack.WebExtensionPart openXmlElement, DMWebExt.WebExtension? value)
  {
    if (value != null)
    {
       var rootElement = DMXWebExt.WebExtensionConverter.CreateOpenXmlElement<DXO2013WebExt.WebExtension>(value);
       if (rootElement != null)
         openXmlElement.WebExtension = rootElement;
    }
  }
  
  public static DMPack.WebExtensionPart? CreateModelElement(DXPack.WebExtensionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WebExtensionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebExtension = GetWebExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WebExtensionPart? value)
    where OpenXmlElementType: DXPack.WebExtensionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetWebExtension(openXmlElement, value?.WebExtension);
      return openXmlElement;
    }
    return default;
  }
}
