namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
public static class ControlPropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.ControlPropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ControlPropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ControlPropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ControlPropertiesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ControlPropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
