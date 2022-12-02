namespace DocumentModel.Drawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface IRelativeAnchorSize // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public IFromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public IToAnchor? ToAnchor { get ; set; }
  
  public IShape? Shape { get ; set; }
  
  public IGroupShape? GroupShape { get ; set; }
  
  public IGraphicFrame? GraphicFrame { get ; set; }
  
  public IConnectionShape? ConnectionShape { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
}
