namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public interface IImageProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public IImageLayer? ImageLayer { get ; set; }
  
}
