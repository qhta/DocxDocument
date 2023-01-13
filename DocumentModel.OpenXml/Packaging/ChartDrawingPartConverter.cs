namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartDrawingPart
/// </summary>
public static class ChartDrawingPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Charts.UserShapes? GetUserShapes(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Charts.UserShapes rootElement)
      return DocumentModel.OpenXml.Drawings.Charts.UserShapesConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetUserShapes(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement, DocumentModel.Drawings.Charts.UserShapes? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Drawings.Charts.UserShapesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UserShapes>(value);
         if (rootElement != null)
           openXmlElement.UserShapes = rootElement;
      }
  }
  
  public static DocumentModel.Packaging.ChartDrawingPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ChartDrawingPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartDrawingPart();
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.UserShapes = GetUserShapes(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ChartDrawingPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ChartDrawingPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetUserShapes(openXmlElement, value?.UserShapes);
      return openXmlElement;
    }
    return default;
  }
}
