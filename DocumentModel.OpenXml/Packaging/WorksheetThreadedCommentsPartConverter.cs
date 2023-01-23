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
  
  private static bool CmpContentType(DXPack.WorksheetThreadedCommentsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WorksheetThreadedCommentsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.WorksheetThreadedCommentsPart? openXmlElement, DMPack.WorksheetThreadedCommentsPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
