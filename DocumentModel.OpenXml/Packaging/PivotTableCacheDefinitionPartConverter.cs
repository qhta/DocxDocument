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
  
  private static String? GetRelationshipType(DXPack.PivotTableCacheDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
