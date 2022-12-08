namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public class ImagePropertiesImpl: ModelElementImpl, ImageProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public ImageLayer? ImageLayer
  {
    get;
    set;
  }
  
}
