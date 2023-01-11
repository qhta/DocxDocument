namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramLayoutDefinitionPart
/// </summary>
public static class DiagramLayoutDefinitionPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramLayoutDefinitionPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.LayoutDefinition? GetLayoutDefinition(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetLayoutDefinition(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutDefinition? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramLayoutDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
