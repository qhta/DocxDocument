namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IImageLayer))]
public class ImageProperties: IImageProperties
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public IImageLayer? ImageLayer
  {
    get;
    set;
  }
  
}
