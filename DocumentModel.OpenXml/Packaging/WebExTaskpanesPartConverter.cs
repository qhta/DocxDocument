namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebExTaskpanesPart
/// </summary>
public static class WebExTaskpanesPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.WebExtensions.UI.Taskpanes? GetTaskpanes(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes rootElement)
      return DocumentModel.OpenXml.WebExtensions.UI.TaskpanesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetTaskpanes(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement, DocumentModel.WebExtensions.UI.Taskpanes? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.WebExtensions.UI.TaskpanesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtentionPane.Taskpanes>(value);
       if (rootElement != null)
         openXmlElement.Taskpanes = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WebExtensionPart> GetWebExtensionParts(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WebExtensionPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WebExtensionPart>())
    {
      var newItem = DocumentModel.OpenXml.Packaging.WebExtensionPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  public static DocumentModel.Packaging.WebExTaskpanesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WebExTaskpanesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart, new()
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
