namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public static class AlternativeFormatImportPartConverter
{
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.AlternativeFormatImportPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.AlternativeFormatImportPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.AlternativeFormatImportPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.AlternativeFormatImportPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
