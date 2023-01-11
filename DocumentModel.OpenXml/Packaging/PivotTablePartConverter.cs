namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the PivotTablePart
/// </summary>
public static class PivotTablePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.PivotTablePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.PivotTablePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.PivotTablePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.PivotTablePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.PivotTablePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.PivotTablePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.PivotTablePart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
