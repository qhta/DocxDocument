namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines a reference relationship. A reference relationship can be internal or external.
/// </summary>
public static class ReferenceRelationshipConverter
{
  /// <summary>
  /// Gets the relationship type.
  /// </summary>
  private static String? GetRelationshipType(DXPack.ReferenceRelationship openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.ReferenceRelationship openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  /// <summary>
  /// Gets a value indicating whether the target of the relationship is Internal or External to the .
  /// </summary>
  private static Boolean? GetIsExternal(DXPack.ReferenceRelationship openXmlElement)
  {
    return openXmlElement?.IsExternal;
  }
  
  private static bool CmpIsExternal(DXPack.ReferenceRelationship openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IsExternal == value) return true;
    diffs?.Add(objName, "IsExternal", openXmlElement?.IsExternal, value);
    return false;
  }
  
  /// <summary>
  /// Gets the relationship ID.
  /// </summary>
  private static String? GetId(DXPack.ReferenceRelationship openXmlElement)
  {
    return openXmlElement?.Id;
  }
  
  private static bool CmpId(DXPack.ReferenceRelationship openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id, value);
    return false;
  }
  
  /// <summary>
  /// Gets the target URI of the relationship.
  /// </summary>
  private static Uri? GetUri(DXPack.ReferenceRelationship openXmlElement)
  {
    return openXmlElement?.Uri;
  }
  
  private static bool CmpUri(DXPack.ReferenceRelationship openXmlElement, Uri? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri, value);
    return false;
  }
  
  public static DocumentModel.Packaging.ReferenceRelationship? CreateModelElement(DXPack.ReferenceRelationship? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ReferenceRelationship();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.IsExternal = GetIsExternal(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.ReferenceRelationship? openXmlElement, DMPack.ReferenceRelationship? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      if (!CmpIsExternal(openXmlElement, value.IsExternal, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.ReferenceRelationship value)
    where OpenXmlElementType: DXPack.ReferenceRelationship, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.ReferenceRelationship openXmlElement, DMPack.ReferenceRelationship value)
  {
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
    //SetIsExternal(openXmlElement, value?.IsExternal);
    //SetId(openXmlElement, value?.Id);
    //SetUri(openXmlElement, value?.Uri);
  }
}
