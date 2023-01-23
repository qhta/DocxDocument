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
  
  private static bool CmpRelationshipType(DXPack.EmbeddedObjectPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.EmbeddedObjectPart? CreateModelElement(DXPack.EmbeddedObjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedObjectPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.EmbeddedObjectPart? openXmlElement, DMPack.EmbeddedObjectPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedObjectPart? value)
    where OpenXmlElementType: DXPack.EmbeddedObjectPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
