namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WebExtensionPart
/// </summary>
public static class WebExtensionPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the WebExtensionPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
    {
      var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.WebExtensions.WebExtension? GetWebExtension(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension rootElement)
      return DocumentModel.OpenXml.WebExtensions.WebExtensionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetWebExtension(DocumentFormat.OpenXml.Packaging.WebExtensionPart openXmlElement, DocumentModel.WebExtensions.WebExtension? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.WebExtensions.WebExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.WebExtension.WebExtension>(value);
       if (rootElement != null)
         openXmlElement.WebExtension = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.WebExtensionPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WebExtensionPart? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WebExtensionPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WebExtensionPart, new()
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
