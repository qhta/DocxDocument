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
  
  private static bool CmpContentType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
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
  
  public static bool CompareModelElement(DXPack.SpreadsheetPrinterSettingsPart? openXmlElement, DMPack.SpreadsheetPrinterSettingsPart? value, DiffList? diffs, string? objName)
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
