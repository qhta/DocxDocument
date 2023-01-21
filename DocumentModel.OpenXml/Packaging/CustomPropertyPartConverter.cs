namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the CustomPropertyPart
/// </summary>
public static class CustomPropertyPartConverter
{
  private static String? GetRelationshipType(DXPack.CustomPropertyPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.CustomPropertyPart? CreateModelElement(DXPack.CustomPropertyPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomPropertyPart();
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomPropertyPart? value)
    where OpenXmlElementType: DXPack.CustomPropertyPart, new()
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
