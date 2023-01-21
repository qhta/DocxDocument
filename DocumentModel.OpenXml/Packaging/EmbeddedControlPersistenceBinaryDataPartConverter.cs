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
