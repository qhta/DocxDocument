namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public static class WordprocessingPrinterSettingsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.WordprocessingPrinterSettingsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.WordprocessingPrinterSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.WordprocessingPrinterSettingsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
