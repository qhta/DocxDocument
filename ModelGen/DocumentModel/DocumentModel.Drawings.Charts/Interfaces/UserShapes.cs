namespace DocumentModel.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public partial interface UserShapes
{
  public DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? RelativeAnchorSize { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? AbsoluteAnchorSize { get; set; }
  
}
