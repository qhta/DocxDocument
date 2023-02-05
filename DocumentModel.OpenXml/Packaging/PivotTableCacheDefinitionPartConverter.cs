namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public static class PivotTableCacheDefinitionPartConverter
{
  private static String? GetContentType(DXPack.PivotTableCacheDefinitionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.PivotTableCacheDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.PivotTableCacheDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.PivotTableCacheDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DMPack.PivotTableCacheDefinitionPart? CreateModelElement(DXPack.PivotTableCacheDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.PivotTableCacheDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.PivotTableCacheDefinitionPart? openXmlElement, DMPack.PivotTableCacheDefinitionPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.PivotTableCacheDefinitionPart? value)
    where OpenXmlElementType: DXPack.PivotTableCacheDefinitionPart, new()
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
