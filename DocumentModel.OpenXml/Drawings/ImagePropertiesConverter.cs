using DocumentModel.Drawings;
using ImageProperties = DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ImageProperties Class.
/// </summary>
public static class ImagePropertiesConverter
{
  /// <summary>
  ///   ImageLayer.
  /// </summary>
  public static ImageLayer? GetImageLayer(ImageProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
    if (itemElement != null)
      return ImageLayerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageLayer(ImageProperties? openXmlElement, ImageLayer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageLayerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ImageProperties? CreateModelElement(ImageProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageProperties();
      value.ImageLayer = GetImageLayer(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ImageProperties? value)
    where OpenXmlElementType : ImageProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetImageLayer(openXmlElement, value?.ImageLayer);
      return openXmlElement;
    }
    return default;
  }
}