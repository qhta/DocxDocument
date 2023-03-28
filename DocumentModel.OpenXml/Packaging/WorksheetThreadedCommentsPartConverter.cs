namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WorksheetThreadedCommentsPar converter from/to OpenXml.
///</summary>
public static class WorksheetThreadedCommentsPartConverter
{
  private static String? GetContentType(DXPack.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.WorksheetThreadedCommentsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.WorksheetThreadedCommentsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WorksheetThreadedCommentsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.WorksheetThreadedCommentsPart? CreateModelElement(DXPack.WorksheetThreadedCommentsPart? openXmlElement)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WorksheetThreadedCommentsPart value)
    where OpenXmlElementType: DXPack.WorksheetThreadedCommentsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WorksheetThreadedCommentsPart openXmlElement, DMPack.WorksheetThreadedCommentsPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
