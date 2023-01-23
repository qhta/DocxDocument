namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedPackagePart
/// </summary>
public static class EmbeddedPackagePartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedPackagePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.EmbeddedPackagePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.EmbeddedPackagePart? CreateModelElement(DXPack.EmbeddedPackagePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedPackagePart();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedPackagePart? value)
    where OpenXmlElementType: DXPack.EmbeddedPackagePart, new()
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
