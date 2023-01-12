namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTableCacheRecordsPart
/// </summary>
public static class PivotTableCacheRecordsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.PivotTableCacheRecordsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.PivotTableCacheRecordsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.PivotTableCacheRecordsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.PivotTableCacheRecordsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
