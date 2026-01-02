using DocumentModel.Drawings.ChartDrawing;
namespace DocumentModel.Drawings.Charts;

/// <summary>
///   User Shapes.
/// </summary>
public class UserShapes: ModelElement
{
  public RelativeAnchorSize? RelativeAnchorSize { get; set; }
  public AbsoluteAnchorSize? AbsoluteAnchorSize { get; set; }
}