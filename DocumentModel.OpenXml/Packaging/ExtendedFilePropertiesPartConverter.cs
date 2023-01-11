namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ExtendedFilePropertiesPart
/// </summary>
public static class ExtendedFilePropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Properties.ExtendedProperties? GetProperties(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetProperties(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? openXmlElement, DocumentModel.Properties.ExtendedProperties? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.ExtendedFilePropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExtendedFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Properties = GetProperties(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ExtendedFilePropertiesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ExtendedFilePropertiesPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
