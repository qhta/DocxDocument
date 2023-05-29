namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Represents a (RelationshipId, OpenXmlPart) pair.
/// </summary>
public static class IdPartPairConverter
{
  /// <summary>
  /// Gets or sets the relationship ID in the pair.
  /// </summary>
  private static String? GetRelationshipId(DXPack.IdPartPair openXmlElement)
  {
    return openXmlElement?.RelationshipId;
  }
  
  private static bool CmpRelationshipId(DXPack.IdPartPair openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipId == value) return true;
    diffs?.Add(objName, "RelationshipId", openXmlElement?.RelationshipId, value);
    return false;
  }
  
  private static void SetRelationshipId(DXPack.IdPartPair openXmlElement, String? value)
  {
    openXmlElement.RelationshipId = value;
  }
  
  public static DocumentModel.Packaging.IdPartPair? CreateModelElement(DXPack.IdPartPair? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.IdPartPair();
      value.RelationshipId = GetRelationshipId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.IdPartPair? openXmlElement, DMPack.IdPartPair? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipId(openXmlElement, value.RelationshipId, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.IdPartPair value)
    where OpenXmlElementType: DXPack.IdPartPair, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.IdPartPair openXmlElement, DMPack.IdPartPair value)
  {
    SetRelationshipId(openXmlElement, value?.RelationshipId);
  }
}
