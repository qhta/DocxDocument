namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomFilePropertiesPart
/// </summary>
public static class CustomFilePropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Properties.CustomProperties? GetProperties(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetProperties(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement, DocumentModel.Properties.CustomProperties? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CustomFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
      SetProperties(openXmlElement, value?.Properties);
      return openXmlElement;
    }
    return default;
  }
}
