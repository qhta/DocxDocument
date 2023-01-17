namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
public static class StylesWithEffectsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.StylesWithEffectsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.StylesWithEffectsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.StylesWithEffectsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart, new()
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
