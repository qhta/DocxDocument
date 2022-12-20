namespace DocumentModel.Drawings.Charts;

/// <summary>
/// User Shapes.
/// </summary>
public partial interface UserShapes
{
  /// <summary>
  /// Gets the ChartDrawingPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.ChartDrawingPart? ChartDrawingPart { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.RelativeAnchorSize? RelativeAnchorSize { get; set; }
  
  public DocumentModel.Drawings.ChartDrawing.AbsoluteAnchorSize? AbsoluteAnchorSize { get; set; }
  
}
