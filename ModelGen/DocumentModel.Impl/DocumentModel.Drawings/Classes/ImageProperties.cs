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
  
  public ImagePropertiesImpl(): base() {}
  
  public ImagePropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public DocumentModel.Drawings.ImageLayer? ImageLayer
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
