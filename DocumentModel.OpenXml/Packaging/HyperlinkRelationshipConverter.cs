namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a hyperlink relationship.
/// </summary>
public static class HyperlinkRelationshipConverter
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  private static String? GetRelationshipType(DXPack.HyperlinkRelationship openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.HyperlinkRelationship openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.HyperlinkRelationship? CreateModelElement(DXPack.HyperlinkRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.HyperlinkRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.HyperlinkRelationship? openXmlElement, DMPack.HyperlinkRelationship? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.HyperlinkRelationship? value)
    where OpenXmlElementType: DXPack.HyperlinkRelationship, new()
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
