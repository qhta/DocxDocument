namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePar converter from/to OpenXml.
///</summary>
public static class EmbeddedPackagePartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedPackagePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.EmbeddedPackagePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.EmbeddedPackagePart? CreateModelElement(DXPack.EmbeddedPackagePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.EmbeddedPackagePart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.EmbeddedPackagePart? openXmlElement, DMPack.EmbeddedPackagePart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedPackagePart value)
    where OpenXmlElementType: DXPack.EmbeddedPackagePart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.EmbeddedPackagePart openXmlElement, DMPack.EmbeddedPackagePart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
