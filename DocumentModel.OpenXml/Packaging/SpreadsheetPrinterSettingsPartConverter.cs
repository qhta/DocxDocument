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
  
  private static bool CmpContentType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  private static String? GetRelationshipType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.SpreadsheetPrinterSettingsPart openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.SpreadsheetPrinterSettingsPart? CreateModelElement(DXPack.SpreadsheetPrinterSettingsPart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.SpreadsheetPrinterSettingsPart? openXmlElement, DMPack.SpreadsheetPrinterSettingsPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName, propName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.SpreadsheetPrinterSettingsPart value)
    where OpenXmlElementType: DXPack.SpreadsheetPrinterSettingsPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.SpreadsheetPrinterSettingsPart openXmlElement, DMPack.SpreadsheetPrinterSettingsPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
