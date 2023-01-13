namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the StyleDefinitionsPart
/// </summary>
public static class StyleDefinitionsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.StyleDefinitionsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.StyleDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.StyleDefinitionsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.StyleDefinitionsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
