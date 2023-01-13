namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomFilePropertiesPart
/// </summary>
public static class CustomFilePropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Properties.CustomProperties? GetProperties(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.CustomProperties.Properties rootElement)
      return DocumentModel.OpenXml.Properties.CustomPropertiesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetProperties(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement, DocumentModel.Properties.CustomProperties? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Properties.CustomPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.CustomProperties.Properties>(value);
         if (rootElement != null)
           openXmlElement.Properties = rootElement;
      }
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.CustomFilePropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CustomFilePropertiesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetProperties(openXmlElement, value?.Properties);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
