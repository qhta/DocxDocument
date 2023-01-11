namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public static class PowerPointCommentPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.PowerPointCommentPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.PowerPointCommentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.PowerPointCommentPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.PowerPointCommentPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.PowerPointCommentPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
