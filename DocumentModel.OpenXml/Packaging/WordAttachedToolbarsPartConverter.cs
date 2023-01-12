namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
public static class WordAttachedToolbarsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.WordAttachedToolbarsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordAttachedToolbarsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordAttachedToolbarsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordAttachedToolbarsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
