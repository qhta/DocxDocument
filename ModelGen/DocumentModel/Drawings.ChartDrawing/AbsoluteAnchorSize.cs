namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Absolute Anchor Shape Size.
/// </summary>
public partial class AbsoluteAnchorSize
{
  
  /// <summary>
  ///   FromAnchor.
  /// </summary>
  public DMDCD.FromAnchor? FromAnchor { get; set; }
  
  
  /// <summary>
  ///   Shape Extent.
  /// </summary>
  public DMDCD.Extent? Extent { get; set; }
  
  public DMDCD.Shape? Shape { get; set; }
  
  public DMDCD.GroupShape? GroupShape { get; set; }
  
  public DMDCD.GraphicFrame? GraphicFrame { get; set; }
  
  public DMDCD.ConnectionShape? ConnectionShape { get; set; }
  
  public DMDCD.Picture? Picture { get; set; }
  
}
