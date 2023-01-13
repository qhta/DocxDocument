namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramColorsPart
/// </summary>
public static class DiagramColorsPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ColorsDefinition? GetColorsDefinition(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetColorsDefinition(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement, DocumentModel.Drawings.Diagrams.ColorsDefinition? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.DiagramColorsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramColorsPart();
      value.ColorsDefinition = GetColorsDefinition(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramColorsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramColorsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetColorsDefinition(openXmlElement, value?.ColorsDefinition);
      return openXmlElement;
    }
    return default;
  }
}
