namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPart
/// </summary>
public static class WorksheetThreadedCommentsPartConverter
{
  private static String? GetContentType(DXPack.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WorksheetThreadedCommentsPart? CreateModelElement(DXPack.WorksheetThreadedCommentsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WorksheetThreadedCommentsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WorksheetThreadedCommentsPart? value)
    where OpenXmlElementType: DXPack.WorksheetThreadedCommentsPart, new()
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
