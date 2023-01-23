namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the Model3DReferenceRelationshipPart
/// </summary>
public static class Model3DReferenceRelationshipPartConverter
{
  private static String? GetContentType(DXPack.Model3DReferenceRelationshipPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static bool CmpContentType(DXPack.Model3DReferenceRelationshipPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ContentType == value;
  }
  
  private static String? GetRelationshipType(DXPack.Model3DReferenceRelationshipPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.Model3DReferenceRelationshipPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.Model3DReferenceRelationshipPart? CreateModelElement(DXPack.Model3DReferenceRelationshipPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.Model3DReferenceRelationshipPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.Model3DReferenceRelationshipPart? openXmlElement, DMPack.Model3DReferenceRelationshipPart? value, DiffList? diffs, string? objName)
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
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.Model3DReferenceRelationshipPart? value)
    where OpenXmlElementType: DXPack.Model3DReferenceRelationshipPart, new()
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
