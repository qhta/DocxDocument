namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramDataPart
/// </summary>
public static class DiagramDataPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.DataModelRoot? GetDataModelRoot(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot rootElement)
      return DocumentModel.OpenXml.Drawings.Diagrams.DataModelRootConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetDataModelRoot(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement, DocumentModel.Drawings.Diagrams.DataModelRoot? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.Drawings.Diagrams.DataModelRootConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DataModelRoot>(value);
       if (rootElement != null)
         openXmlElement.DataModelRoot = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramDataPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
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
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets the SlideParts of the DiagramDataPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.SlidePart> GetSlideParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
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
  
  /// <summary>
  /// Gets the WorksheetParts of the DiagramDataPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.WorksheetPart> GetWorksheetParts(DocumentFormat.OpenXml.Packaging.DiagramDataPart openXmlElement)
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
      //SetContentType(openXmlElement, value?.ContentType);
      SetDataModelRoot(openXmlElement, value?.DataModelRoot);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      //SetSlideParts(openXmlElement, value?.SlideParts);
      //SetWorksheetParts(openXmlElement, value?.WorksheetParts);
      return openXmlElement;
    }
    return default;
  }
}
