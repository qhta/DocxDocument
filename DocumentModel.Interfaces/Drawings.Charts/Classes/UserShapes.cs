using DocumentModel.Drawings.ChartDrawing;
namespace DocumentModel.Drawings.Charts;

/// <summary>
///   User Shapes.
/// </summary>
public interface UserShapes: IModelElement
{
  public RelativeAnchorSize? RelativeAnchorSize { get; set; }
  public AbsoluteAnchorSize? AbsoluteAnchorSize { get; set; }
}