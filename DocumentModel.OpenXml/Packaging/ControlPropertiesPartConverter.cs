namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ControlPropertiesPart
/// </summary>
public static class ControlPropertiesPartConverter
{
  private static String? GetContentType(DXPack.ControlPropertiesPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.ControlPropertiesPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.ControlPropertiesPart? CreateModelElement(DXPack.ControlPropertiesPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.ControlPropertiesPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.ControlPropertiesPart? value)
    where OpenXmlElementType: DXPack.ControlPropertiesPart, new()
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
