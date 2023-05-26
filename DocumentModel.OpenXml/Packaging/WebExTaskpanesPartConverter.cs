namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebExTaskpanesPart
/// </summary>
public static class WebExTaskpanesPartConverter
{
  private static String? GetContentType(DXPack.WebExTaskpanesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.WebExTaskpanesPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.WebExTaskpanesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WebExTaskpanesPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMWEUI.Taskpanes? GetTaskpanes(DXPack.WebExTaskpanesPart openXmlElement)
  {
      return DMXWEUI.TaskpanesConverter.CreateModelElement(openXmlElement?.RootElement as DXO13WEP.Taskpanes);
  }
  
  private static bool CmpTaskpanes(DXPack.WebExTaskpanesPart openXmlElement, DMWEUI.Taskpanes? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetTaskpanes(DXPack.WebExTaskpanesPart openXmlElement, DMWEUI.Taskpanes? value)
  {
    if (value != null)
    {
       var rootElement = DMXWEUI.TaskpanesConverter.CreateOpenXmlElement<DXO13WEP.Taskpanes>(value);
       if (rootElement != null)
         openXmlElement.Taskpanes = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  private static Collection<DMPack.WebExtensionPart>? GetWebExtensionParts(DXPack.WebExTaskpanesPart openXmlElement)
  {
    var collection = new Collection<DMPack.WebExtensionPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.WebExtensionPart>())
    {
      var newItem = DMXPack.WebExtensionPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpWebExtensionParts(DXPack.WebExTaskpanesPart openXmlElement, Collection<DMPack.WebExtensionPart>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return true;
  }
  
  public static DocumentModel.Packaging.WebExTaskpanesPart? CreateModelElement(DXPack.WebExTaskpanesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WebExTaskpanesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Taskpanes = GetTaskpanes(openXmlElement);
      value.WebExtensionParts = GetWebExtensionParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.WebExTaskpanesPart? openXmlElement, DMPack.WebExTaskpanesPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      if (!CmpTaskpanes(openXmlElement, value.Taskpanes, diffs, objName, propName))
        ok = false;
      if (!CmpWebExtensionParts(openXmlElement, value.WebExtensionParts, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WebExTaskpanesPart value)
    where OpenXmlElementType: DXPack.WebExTaskpanesPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WebExTaskpanesPart openXmlElement, DMPack.WebExTaskpanesPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    SetTaskpanes(openXmlElement, value?.Taskpanes);
    //SetWebExtensionParts(openXmlElement, value?.WebExtensionParts);
  }
}
