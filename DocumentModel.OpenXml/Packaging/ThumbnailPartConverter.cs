namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ThumbnailPart
/// </summary>
public static class ThumbnailPartConverter
{
  private static String? GetRelationshipType(DXPack.ThumbnailPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ThumbnailPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.ThumbnailPart? CreateModelElement(DXPack.ThumbnailPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ThumbnailPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ThumbnailPart? openXmlElement, DMPack.ThumbnailPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThumbnailPart? value)
    where OpenXmlElementType: DXPack.ThumbnailPart, new()
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
