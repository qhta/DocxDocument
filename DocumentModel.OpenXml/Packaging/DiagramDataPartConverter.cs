namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public static class DiagramDataPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.DataModelRoot? GetDataModelRoot(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetDataModelRoot(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement, DocumentModel.Drawings.Diagrams.DataModelRoot? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlidePart>? GetSlideParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlidePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.SlidePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.SlidePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WorksheetPart>? GetWorksheetParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WorksheetPart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.WorksheetPart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.WorksheetPartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static DocumentModel.Packaging.DiagramDataPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.DataModelRoot = GetDataModelRoot(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.SlideParts = GetSlideParts(openXmlElement);
      value.WorksheetParts = GetWorksheetParts(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramDataPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDataModelRoot(openXmlElement, value?.DataModelRoot);
      return openXmlElement;
    }
    return default;
  }
}
