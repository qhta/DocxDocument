namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
public static class WorksheetThreadedCommentsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
