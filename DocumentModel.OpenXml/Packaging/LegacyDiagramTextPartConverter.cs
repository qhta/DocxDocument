namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the LegacyDiagramTextPart
/// </summary>
public static class LegacyDiagramTextPartConverter
{
  private static String? GetContentType(DXPack.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.LegacyDiagramTextPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.LegacyDiagramTextPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.LegacyDiagramTextPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.LegacyDiagramTextPart? CreateModelElement(DXPack.LegacyDiagramTextPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.LegacyDiagramTextPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.LegacyDiagramTextPart? openXmlElement, DMPack.LegacyDiagramTextPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.LegacyDiagramTextPart? value)
    where OpenXmlElementType: DXPack.LegacyDiagramTextPart, new()
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
