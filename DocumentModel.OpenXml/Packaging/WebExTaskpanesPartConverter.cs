namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebExTaskpanesPart
/// </summary>
public static class WebExTaskpanesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.WebExtensions.UI.Taskpanes? GetTaskpanes(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetTaskpanes(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement, DocumentModel.WebExtensions.UI.Taskpanes? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the WebExtensionParts of the WebExTaskpanesPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WebExtensionPart>? GetWebExtensionParts(DocumentFormat.OpenXml.Packaging.WebExTaskpanesPart? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
