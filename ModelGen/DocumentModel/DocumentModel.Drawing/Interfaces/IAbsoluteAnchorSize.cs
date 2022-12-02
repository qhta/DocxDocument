namespace DocumentModel.Drawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawing.IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawing.IExtent? Extent { get ; set; }
  
  public DocumentModel.Drawing.IShape? Shape { get ; set; }
  
  public DocumentModel.Drawing.IGroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawing.IGraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawing.IConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawing.IPicture? Picture { get ; set; }
  
}
