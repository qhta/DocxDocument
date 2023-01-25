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
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.CustomXmlPart? CreateModelElement(DXPack.CustomXmlPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomXmlPart();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomXmlPart? value)
    where OpenXmlElementType: DXPack.CustomXmlPart, new()
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
