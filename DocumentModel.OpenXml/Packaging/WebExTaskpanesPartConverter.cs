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
  
  private static String? GetRelationshipType(DXPack.WebExTaskpanesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMWebExtUI.Taskpanes? GetTaskpanes(DXPack.WebExTaskpanesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXO2013WebExtPane.Taskpanes rootElement)
      return DMXWebExtUI.TaskpanesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetTaskpanes(DXPack.WebExTaskpanesPart openXmlElement, DMWebExtUI.Taskpanes? value)
  {
    if (value != null)
    {
       var rootElement = DMXWebExtUI.TaskpanesConverter.CreateOpenXmlElement<DXO2013WebExtPane.Taskpanes>(value);
       if (rootElement != null)
         openXmlElement.Taskpanes = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  private static Collection<DMPack.WebExtensionPart> GetWebExtensionParts(DXPack.WebExTaskpanesPart openXmlElement)
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
  
  public static DMPack.WebExTaskpanesPart? CreateModelElement(DXPack.WebExTaskpanesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WebExTaskpanesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.Taskpanes = GetTaskpanes(openXmlElement);
      value.WebExtensionParts = GetWebExtensionParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WebExTaskpanesPart? value)
    where OpenXmlElementType: DXPack.WebExTaskpanesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetTaskpanes(openXmlElement, value?.Taskpanes);
      //SetWebExtensionParts(openXmlElement, value?.WebExtensionParts);
      return openXmlElement;
    }
    return default;
  }
}
