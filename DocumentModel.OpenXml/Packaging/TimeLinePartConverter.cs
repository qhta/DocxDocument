namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the TimeLinePart
/// </summary>
public static class TimeLinePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.TimeLinePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.TimeLinePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.TimeLinePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.TimeLinePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.TimeLinePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.TimeLinePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.TimeLinePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
