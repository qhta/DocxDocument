namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistenceBinaryDataPart
/// </summary>
public static class EmbeddedControlPersistenceBinaryDataPartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedControlPersistenceBinaryDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.EmbeddedControlPersistenceBinaryDataPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.EmbeddedControlPersistenceBinaryDataPart? CreateModelElement(DXPack.EmbeddedControlPersistenceBinaryDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedControlPersistenceBinaryDataPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.EmbeddedControlPersistenceBinaryDataPart? openXmlElement, DMPack.EmbeddedControlPersistenceBinaryDataPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedControlPersistenceBinaryDataPart? value)
    where OpenXmlElementType: DXPack.EmbeddedControlPersistenceBinaryDataPart, new()
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
