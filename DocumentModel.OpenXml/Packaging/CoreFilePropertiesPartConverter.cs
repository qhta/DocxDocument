namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CoreFilePropertiesPart
/// </summary>
public static class CoreFilePropertiesPartConverter
{
  private static String? GetContentType(DXPack.CoreFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.CoreFilePropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.CoreFilePropertiesPart? CreateModelElement(DXPack.CoreFilePropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CoreFilePropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CoreFilePropertiesPart? value)
    where OpenXmlElementType: DXPack.CoreFilePropertiesPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
