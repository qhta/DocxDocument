namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Relative Anchor Shape Size.
/// </summary>
public partial class RelativeAnchorSize
{
  
  /// <summary>
  ///   Starting Anchor Point.
  /// </summary>
  public DMDCD.FromAnchor? FromAnchor { get; set; }
  
  
  /// <summary>
  ///   Ending Anchor Point.
  /// </summary>
  public DMDCD.ToAnchor? ToAnchor { get; set; }
  
  public DMDCD.Shape? Shape { get; set; }
  
  public DMDCD.GroupShape? GroupShape { get; set; }
  
  public DMDCD.GraphicFrame? GraphicFrame { get; set; }
  
  public DMDCD.ConnectionShape? ConnectionShape { get; set; }
  
  public DMDCD.Picture? Picture { get; set; }
  
}
