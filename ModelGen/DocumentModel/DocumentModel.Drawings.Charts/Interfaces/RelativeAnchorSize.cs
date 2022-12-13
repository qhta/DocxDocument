namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface RelativeAnchorSize
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Charts.FromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.Charts.ToAnchor? ToAnchor { get ; set; }
  
  public DocumentModel.Drawings.Charts.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.GraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawings.Charts.ConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawings.Charts.Picture? Picture { get ; set; }
  
}
