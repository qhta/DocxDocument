namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTableCacheRecordsPart
/// </summary>
public static class PivotTableCacheRecordsPartConverter
{
  private static String? GetContentType(DXPack.PivotTableCacheRecordsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.PivotTableCacheRecordsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.PivotTableCacheRecordsPart? CreateModelElement(DXPack.PivotTableCacheRecordsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.PivotTableCacheRecordsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.PivotTableCacheRecordsPart? value)
    where OpenXmlElementType: DXPack.PivotTableCacheRecordsPart, new()
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
