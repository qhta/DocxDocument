namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
public static class StylesWithEffectsPartConverter
{
  private static String? GetContentType(DXPack.StylesWithEffectsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DXPack.StylesWithEffectsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.StylesWithEffectsPart? CreateModelElement(DXPack.StylesWithEffectsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.StylesWithEffectsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.StylesWithEffectsPart? value)
    where OpenXmlElementType: DXPack.StylesWithEffectsPart, new()
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
