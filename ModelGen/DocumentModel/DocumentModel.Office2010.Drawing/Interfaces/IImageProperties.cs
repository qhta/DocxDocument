namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ImageProperties Class.
/// </summary>
public interface IImageProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ImageLayer.
  /// </summary>
  public DocumentModel.Office2010.Drawing.IImageLayer? ImageLayer { get ; set; }
  
}
