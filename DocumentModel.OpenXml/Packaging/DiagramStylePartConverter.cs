namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public static class DiagramStylePartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.StyleDefinition? GetStyleDefinition(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition rootElement)
      return DocumentModel.OpenXml.Drawings.Diagrams.StyleDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetStyleDefinition(DocumentFormat.OpenXml.Packaging.DiagramStylePart openXmlElement, DocumentModel.Drawings.Diagrams.StyleDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.Diagrams.StyleDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.StyleDefinition>(value);
       if (rootElement != null)
         openXmlElement.StyleDefinition = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.DiagramStylePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramStylePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramStylePart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.StyleDefinition = GetStyleDefinition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramStylePart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramStylePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetStyleDefinition(openXmlElement, value?.StyleDefinition);
      return openXmlElement;
    }
    return default;
  }
}
