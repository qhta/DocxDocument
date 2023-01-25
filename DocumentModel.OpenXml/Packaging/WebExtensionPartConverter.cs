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
  
  private static bool CmpContentType(DXPack.WebExtensionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
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
  
  private static bool CmpImageParts(DXPack.WebExtensionPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WebExtensionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMWebExt.WebExtension? GetWebExtension(DXPack.WebExtensionPart openXmlElement)
  {
      return DMXWebExt.WebExtensionConverter.CreateModelElement(openXmlElement?.RootElement as DXO2013WebExt.WebExtension);
  }
  
  private static bool CmpWebExtension(DXPack.WebExtensionPart openXmlElement, DMWebExt.WebExtension? value, DiffList? diffs, string? objName)
  {
      return true;
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
  
  public static bool CompareModelElement(DXPack.WebExtensionPart? openXmlElement, DMPack.WebExtensionPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpWebExtension(openXmlElement, value.WebExtension, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
