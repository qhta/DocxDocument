using DocumentFormat.OpenXml.Packaging;
using DocumentModel.Drawings.Charts;
using DocumentModel.OpenXml.Drawings.Charts;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ChartDrawingPart
/// </summary>
public static class ChartDrawingPartConverter
{
  public static String? GetContentType(ChartDrawingPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the ChartDrawingPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(ChartDrawingPart? openXmlElement)
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

  public static String? GetRelationshipType(ChartDrawingPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static UserShapes? GetUserShapes(ChartDrawingPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Charts.UserShapes rootElement)
      return UserShapesConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetUserShapes(ChartDrawingPart? openXmlElement, UserShapes? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = UserShapesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.UserShapes>(value);
        if (rootElement != null)
          openXmlElement.UserShapes = rootElement;
      }
  }

  public static DocumentModel.Packaging.ChartDrawingPart? CreateModelElement(ChartDrawingPart? openXmlElement)
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
    where OpenXmlElementType : ChartDrawingPart, new()
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