namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PowerPointCommentPart
/// </summary>
public static class PowerPointCommentPartConverter
{
  private static String? GetContentType(DXPack.PowerPointCommentPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.PowerPointCommentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.PowerPointCommentPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.PowerPointCommentPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.PowerPointCommentPart? CreateModelElement(DXPack.PowerPointCommentPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.PowerPointCommentPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.PowerPointCommentPart? openXmlElement, DMPack.PowerPointCommentPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.PowerPointCommentPart? value)
    where OpenXmlElementType: DXPack.PowerPointCommentPart, new()
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
