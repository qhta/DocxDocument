namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public partial interface AbsoluteAnchorSize
{
  /// <summary>
  /// FromAnchor.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.FromAnchor? FromAnchor { get; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawing.Extent? Extent { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Shape? Shape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GroupShape? GroupShape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.GraphicFrame? GraphicFrame { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.ConnectionShape? ConnectionShape { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.Picture? Picture { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ContentPart? ContentPart { get; set; }
  
}
