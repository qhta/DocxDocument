namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CoreFilePropertiesPart
/// </summary>
public static class CoreFilePropertiesPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.CoreFilePropertiesPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CoreFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.CoreFilePropertiesPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.CoreFilePropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
