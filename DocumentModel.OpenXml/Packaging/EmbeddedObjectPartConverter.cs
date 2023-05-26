namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public static class EmbeddedObjectPartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedObjectPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.EmbeddedObjectPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.EmbeddedObjectPart? CreateModelElement(DXPack.EmbeddedObjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedObjectPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.EmbeddedObjectPart? openXmlElement, DMPack.EmbeddedObjectPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedObjectPart value)
    where OpenXmlElementType: DXPack.EmbeddedObjectPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.EmbeddedObjectPart openXmlElement, DMPack.EmbeddedObjectPart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
