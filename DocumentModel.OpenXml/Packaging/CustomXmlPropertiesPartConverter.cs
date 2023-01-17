namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPropertiesPart
/// </summary>
public static class CustomXmlPropertiesPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.CustomXml.DataStoreItem? GetDataStoreItem(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem rootElement)
      return DocumentModel.OpenXml.CustomXml.DataStoreItemConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetDataStoreItem(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart openXmlElement, DocumentModel.CustomXml.DataStoreItem? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.CustomXml.DataStoreItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem>(value);
       if (rootElement != null)
         openXmlElement.DataStoreItem = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.CustomXmlPropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomXmlPropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataStoreItem = GetDataStoreItem(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomXmlPropertiesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomXmlPropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDataStoreItem(openXmlElement, value?.DataStoreItem);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
