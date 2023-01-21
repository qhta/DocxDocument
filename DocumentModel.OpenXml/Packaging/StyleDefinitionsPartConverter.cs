namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public static class StyleDefinitionsPartConverter
{
  private static String? GetContentType(DXPack.StyleDefinitionsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.StyleDefinitionsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.StyleDefinitionsPart? CreateModelElement(DXPack.StyleDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.StyleDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.StyleDefinitionsPart? value)
    where OpenXmlElementType: DXPack.StyleDefinitionsPart, new()
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
