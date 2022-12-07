namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public class ImagePropertiesImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageProperties>, ImageProperties
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public ImageLayer? ImageLayer
  {
    get;
    set;
  }
  
}
