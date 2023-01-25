namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedControlPersistencePart
/// </summary>
public static class EmbeddedControlPersistencePartConverter
{
  /// <summary>
  /// Gets the EmbeddedControlPersistenceBinaryDataParts of the EmbeddedControlPersistencePart
  /// </summary>
  private static Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart> GetEmbeddedControlPersistenceBinaryDataParts(DXPack.EmbeddedControlPersistencePart openXmlElement)
  {
    var collection = new Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.EmbeddedControlPersistenceBinaryDataPart>())
    {
      var newItem = DMXPack.EmbeddedControlPersistenceBinaryDataPartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpEmbeddedControlPersistenceBinaryDataParts(DXPack.EmbeddedControlPersistencePart openXmlElement, Collection<DMPack.EmbeddedControlPersistenceBinaryDataPart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.EmbeddedControlPersistencePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.EmbeddedControlPersistencePart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.RelationshipType == value;
  }
  
  public static DMPack.EmbeddedControlPersistencePart? CreateModelElement(DXPack.EmbeddedControlPersistencePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedControlPersistencePart();
      value.EmbeddedControlPersistenceBinaryDataParts = GetEmbeddedControlPersistenceBinaryDataParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.EmbeddedControlPersistencePart? openXmlElement, DMPack.EmbeddedControlPersistencePart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value.EmbeddedControlPersistenceBinaryDataParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedControlPersistencePart? value)
    where OpenXmlElementType: DXPack.EmbeddedControlPersistencePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetEmbeddedControlPersistenceBinaryDataParts(openXmlElement, value?.EmbeddedControlPersistenceBinaryDataParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
