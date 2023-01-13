namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the NumberingDefinitionsPart
/// </summary>
public static class NumberingDefinitionsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the NumberingDefinitionsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement)
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
  public static DocumentModel.Wordprocessing.Numbering? GetNumbering(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Numbering rootElement)
      return DocumentModel.OpenXml.Wordprocessing.NumberingConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetNumbering(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement, DocumentModel.Wordprocessing.Numbering? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Wordprocessing.NumberingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Numbering>(value);
         if (rootElement != null)
           openXmlElement.Numbering = rootElement;
      }
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.NumberingDefinitionsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.NumberingDefinitionsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.Numbering = GetNumbering(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.NumberingDefinitionsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.NumberingDefinitionsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      SetNumbering(openXmlElement, value?.Numbering);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
