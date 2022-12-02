namespace DocumentModel.Drawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
  public IShape? Shape { get ; set; }
  
  public IGroupShape? GroupShape { get ; set; }
  
  public IGraphicFrame? GraphicFrame { get ; set; }
  
  public IConnectionShape? ConnectionShape { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
}
