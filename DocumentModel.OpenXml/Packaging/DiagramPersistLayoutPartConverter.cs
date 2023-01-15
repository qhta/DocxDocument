using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Office;
using DocumentModel.OpenXml.Drawings.Office;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the DiagramPersistLayoutPart
/// </summary>
public static class DiagramPersistLayoutPartConverter
{
  public static String? GetContentType(DiagramPersistLayoutPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static Drawing? GetDrawing(DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Drawing.Drawing rootElement)
      return DrawingConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetDrawing(DiagramPersistLayoutPart? openXmlElement, Drawing? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = DrawingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Drawing>(value);
        if (rootElement != null)
          openXmlElement.Drawing = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ImageParts of the DiagramPersistLayoutPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(DiagramPersistLayoutPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(DiagramPersistLayoutPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.DiagramPersistLayoutPart? CreateModelElement(DiagramPersistLayoutPart? openXmlElement)
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
    where OpenXmlElementType : DiagramPersistLayoutPart, new()
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