namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the SlideSyncDataPart
/// </summary>
public static class SlideSyncDataPartConverter
{
  private static String? GetContentType(DXPack.SlideSyncDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.SlideSyncDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.SlideSyncDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.SlideSyncDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.SlideSyncDataPart? CreateModelElement(DXPack.SlideSyncDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.SlideSyncDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.SlideSyncDataPart? openXmlElement, DMPack.SlideSyncDataPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.SlideSyncDataPart? value)
    where OpenXmlElementType: DXPack.SlideSyncDataPart, new()
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
