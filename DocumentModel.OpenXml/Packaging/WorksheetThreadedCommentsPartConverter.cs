namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
public static class WorksheetThreadedCommentsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.WorksheetThreadedCommentsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WorksheetThreadedCommentsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WorksheetThreadedCommentsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
