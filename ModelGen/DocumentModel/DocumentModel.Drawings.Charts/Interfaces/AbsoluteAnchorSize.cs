namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface AbsoluteAnchorSize
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawings.Charts.FromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawings.Charts.Extent? Extent { get ; set; }
  
  public DocumentModel.Drawings.Charts.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawings.Charts.ConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.Picture? Picture { get ; set; }
  
}
