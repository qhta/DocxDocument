namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public static class SpreadsheetPrinterSettingsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.SpreadsheetPrinterSettingsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.SpreadsheetPrinterSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.SpreadsheetPrinterSettingsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.SpreadsheetPrinterSettingsPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
