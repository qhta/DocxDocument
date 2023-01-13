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
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition rootElement)
      return DocumentModel.OpenXml.Drawings.Diagrams.ColorsDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetColorsDefinition(DocumentFormat.OpenXml.Packaging.DiagramColorsPart? openXmlElement, DocumentModel.Drawings.Diagrams.ColorsDefinition? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Drawings.Diagrams.ColorsDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ColorsDefinition>(value);
         if (rootElement != null)
           openXmlElement.ColorsDefinition = rootElement;
      }
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
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
