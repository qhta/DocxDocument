namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public static class WordprocessingPrinterSettingsPartConverter
{
  private static String? GetContentType(DXPack.WordprocessingPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.WordprocessingPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.WordprocessingPrinterSettingsPart? CreateModelElement(DXPack.WordprocessingPrinterSettingsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.WordprocessingPrinterSettingsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.WordprocessingPrinterSettingsPart? value)
    where OpenXmlElementType: DXPack.WordprocessingPrinterSettingsPart, new()
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
