namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SpreadsheetPrinterSettingsPart
/// </summary>
public static class SpreadsheetPrinterSettingsPartConverter
{
  private static String? GetContentType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.SpreadsheetPrinterSettingsPart? CreateModelElement(DXPack.SpreadsheetPrinterSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SpreadsheetPrinterSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SpreadsheetPrinterSettingsPart? value)
    where OpenXmlElementType: DXPack.SpreadsheetPrinterSettingsPart, new()
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
