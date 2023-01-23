namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the AlternativeFormatImportPart
/// </summary>
public static class AlternativeFormatImportPartConverter
{
  private static String? GetRelationshipType(DXPack.AlternativeFormatImportPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.AlternativeFormatImportPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.AlternativeFormatImportPart? CreateModelElement(DXPack.AlternativeFormatImportPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.AlternativeFormatImportPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.AlternativeFormatImportPart? openXmlElement, DMPack.AlternativeFormatImportPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.AlternativeFormatImportPart? value)
    where OpenXmlElementType: DXPack.AlternativeFormatImportPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
