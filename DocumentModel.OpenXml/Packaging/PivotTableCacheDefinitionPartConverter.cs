namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTableCacheDefinitionPart
/// </summary>
public static class PivotTableCacheDefinitionPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.PivotTableCacheDefinitionPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.PivotTableCacheDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.PivotTableCacheDefinitionPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.PivotTableCacheDefinitionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
