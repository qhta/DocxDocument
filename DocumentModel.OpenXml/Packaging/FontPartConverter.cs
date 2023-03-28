namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FontPar converter from/to OpenXml.
///</summary>
public static class FontPartConverter
{
  private static String? GetRelationshipType(DXPack.FontPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.FontPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.FontPart? CreateModelElement(DXPack.FontPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.FontPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.FontPart? openXmlElement, DMPack.FontPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.FontPart value)
    where OpenXmlElementType: DXPack.FontPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.FontPart openXmlElement, DMPack.FontPart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
