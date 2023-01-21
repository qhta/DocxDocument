namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the FontPart
/// </summary>
public static class FontPartConverter
{
  private static String? GetRelationshipType(DXPack.FontPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.FontPart? CreateModelElement(DXPack.FontPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.FontPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.FontPart? value)
    where OpenXmlElementType: DXPack.FontPart, new()
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
