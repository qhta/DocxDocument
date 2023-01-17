namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public static class DiagramLayoutDefinitionPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
    {
      var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.LayoutDefinition? GetLayoutDefinition(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition rootElement)
      return DocumentModel.OpenXml.Drawings.Diagrams.LayoutDefinitionConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetLayoutDefinition(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement, DocumentModel.Drawings.Diagrams.LayoutDefinition? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.Diagrams.LayoutDefinitionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutDefinition>(value);
       if (rootElement != null)
         openXmlElement.LayoutDefinition = rootElement;
    }
  }
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.DiagramLayoutDefinitionPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramLayoutDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.LayoutDefinition = GetLayoutDefinition(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramLayoutDefinitionPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetLayoutDefinition(openXmlElement, value?.LayoutDefinition);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
