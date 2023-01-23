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
  
  private static bool CmpContentType(DXPack.WordprocessingPrinterSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.WordprocessingPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.WordprocessingPrinterSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.WordprocessingPrinterSettingsPart? openXmlElement, DMPack.WordprocessingPrinterSettingsPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
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
