namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
public static class CustomPropertyPartConverter
{
  private static String? GetRelationshipType(DXPack.CustomPropertyPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.CustomPropertyPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.CustomPropertyPart? CreateModelElement(DXPack.CustomPropertyPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomPropertyPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.CustomPropertyPart? openXmlElement, DMPack.CustomPropertyPart? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomPropertyPart value)
    where OpenXmlElementType: DXPack.CustomPropertyPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomPropertyPart openXmlElement, DMPack.CustomPropertyPart value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    }
  }
