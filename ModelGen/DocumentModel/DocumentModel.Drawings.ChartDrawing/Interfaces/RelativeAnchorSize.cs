namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface RelativeAnchorSize
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.FromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.ToAnchor? ToAnchor { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Shape? Shape { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GroupShape? GroupShape { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GraphicFrame? GraphicFrame { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawing.ConnectionShape? ConnectionShape { get ; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Picture? Picture { get ; set; }
  
}
