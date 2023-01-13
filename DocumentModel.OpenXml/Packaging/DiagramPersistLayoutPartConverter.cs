namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the DiagramPersistLayoutPart
/// </summary>
public static class DiagramPersistLayoutPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Office.Drawing? GetDrawing(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Drawing.Drawing rootElement)
      return DocumentModel.OpenXml.Drawings.Office.DrawingConverter.CreateModelElement(rootElement);
    return null;
  }
  
  public static void SetDrawing(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement, DocumentModel.Drawings.Office.Drawing? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
         var rootElement = DocumentModel.OpenXml.Drawings.Office.DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Drawing>(value);
         if (rootElement != null)
           openXmlElement.Drawing = rootElement;
      }
  }
  
  /// <summary>
  /// Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.DiagramPersistLayoutPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.DiagramPersistLayoutPart();
      value.ContentType = GetContentType(openXmlElement);
      value.Drawing = GetDrawing(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.DiagramPersistLayoutPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.DiagramPersistLayoutPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      SetDrawing(openXmlElement, value?.Drawing);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
