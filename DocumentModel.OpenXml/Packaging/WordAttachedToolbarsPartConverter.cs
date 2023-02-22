namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordAttachedToolbarsPart
/// </summary>
public static class WordAttachedToolbarsPartConverter
{
  private static String? GetContentType(DXPack.WordAttachedToolbarsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.WordAttachedToolbarsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.WordAttachedToolbarsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WordAttachedToolbarsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.WordAttachedToolbarsPart? CreateModelElement(DXPack.WordAttachedToolbarsPart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.WordAttachedToolbarsPart? openXmlElement, DMPack.WordAttachedToolbarsPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordAttachedToolbarsPart value)
    where OpenXmlElementType: DXPack.WordAttachedToolbarsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.WordAttachedToolbarsPart openXmlElement, DMPack.WordAttachedToolbarsPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
