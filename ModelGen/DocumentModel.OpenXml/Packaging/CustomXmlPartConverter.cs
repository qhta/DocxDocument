namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomXmlPart
/// </summary>
public static class CustomXmlPartConverter
{
  private static String? GetRelationshipType(DXPack.CustomXmlPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.CustomXmlPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.CustomXmlPart? CreateModelElement(DXPack.CustomXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomXmlPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.CustomXmlPart? openXmlElement, DMPack.CustomXmlPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomXmlPart value)
    where OpenXmlElementType: DXPack.CustomXmlPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomXmlPart openXmlElement, DMPack.CustomXmlPart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
