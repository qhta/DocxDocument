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
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ThumbnailPart? CreateModelElement(DXPack.ThumbnailPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ThumbnailPart();
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ThumbnailPart value)
    where OpenXmlElementType: DXPack.ThumbnailPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ThumbnailPart openXmlElement, DMPack.ThumbnailPart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    }
  }
