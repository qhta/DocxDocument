namespace DocumentModel.Drawings;

/// <summary>
/// Relative Anchor Shape Size.
/// </summary>
public interface RelativeAnchorSize
{
  /// <summary>
  /// Starting Anchor Point.
  /// </summary>
  public FromAnchor? FromAnchor { get ; set; }
  
  /// <summary>
  /// Ending Anchor Point.
  /// </summary>
  public ToAnchor? ToAnchor { get ; set; }
  
  public Shape? Shape { get ; set; }
  
  public GroupShape? GroupShape { get ; set; }
  
  public GraphicFrame? GraphicFrame { get ; set; }
  
  public ConnectionShape? ConnectionShape { get ; set; }
  
  public Picture? Picture { get ; set; }
  
}
