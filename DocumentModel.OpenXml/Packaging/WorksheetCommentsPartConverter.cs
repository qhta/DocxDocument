namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetCommentsPart
/// </summary>
public static class WorksheetCommentsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.WorksheetCommentsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WorksheetCommentsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WorksheetCommentsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WorksheetCommentsPart, new()
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
