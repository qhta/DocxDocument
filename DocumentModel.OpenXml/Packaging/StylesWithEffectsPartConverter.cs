namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the StylesWithEffectsPart
/// </summary>
public static class StylesWithEffectsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.StylesWithEffectsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
