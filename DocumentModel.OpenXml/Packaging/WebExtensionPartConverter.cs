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
  
  private static bool CmpContentType(DXPack.WebExtensionPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  private static Collection<DMPack.ImagePart>? GetImageParts(DXPack.WebExtensionPart openXmlElement)
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
  
  private static bool CmpImageParts(DXPack.WebExtensionPart openXmlElement, Collection<DMPack.ImagePart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WebExtensionPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMWE.WebExtension? GetWebExtension(DXPack.WebExtensionPart openXmlElement)
  {
      return DMXWE.WebExtensionConverter.CreateModelElement(openXmlElement?.RootElement as DXO13WE.WebExtension);
  }
  
  private static bool CmpWebExtension(DXPack.WebExtensionPart openXmlElement, DMWE.WebExtension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetWebExtension(DXPack.WebExtensionPart openXmlElement, DMWE.WebExtension? value)
  {
    if (value != null)
    {
       var rootElement = DMXWE.WebExtensionConverter.CreateOpenXmlElement<DXO13WE.WebExtension>(value);
       if (rootElement != null)
         openXmlElement.WebExtension = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.WebExtensionPart? CreateModelElement(DXPack.WebExtensionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WebExtensionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.WebExtension = GetWebExtension(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.WebExtensionPart? openXmlElement, DMPack.WebExtensionPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpImageParts(openXmlElement, value.ImageParts, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      if (!CmpWebExtension(openXmlElement, value.WebExtension, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WebExtensionPart value)
    where OpenXmlElementType: DXPack.WebExtensionPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WebExtensionPart openXmlElement, DMPack.WebExtensionPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetImageParts(openXmlElement, value?.ImageParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetWebExtension(openXmlElement, value?.WebExtension);
  }
}
