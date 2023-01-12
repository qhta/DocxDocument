namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramStylePart
/// </summary>
public static class DiagramStylePartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.StyleDefinition? GetStyleDefinition(DocumentFormat.OpenXml.Packaging.DiagramStylePart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetStyleDefinition(DocumentFormat.OpenXml.Packaging.DiagramStylePart? openXmlElement, DocumentModel.Drawings.Diagrams.StyleDefinition? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
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
      SetStyleDefinition(openXmlElement, value?.StyleDefinition);
      return openXmlElement;
    }
    return default;
  }
}
