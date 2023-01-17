namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public static class WordprocessingPrinterSettingsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.WordprocessingPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
