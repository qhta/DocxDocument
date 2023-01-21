namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the EmbeddedObjectPart
/// </summary>
public static class EmbeddedObjectPartConverter
{
  private static String? GetRelationshipType(DXPack.EmbeddedObjectPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.EmbeddedObjectPart? CreateModelElement(DXPack.EmbeddedObjectPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.EmbeddedObjectPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.EmbeddedObjectPart? value)
    where OpenXmlElementType: DXPack.EmbeddedObjectPart, new()
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
