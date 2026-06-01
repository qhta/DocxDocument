using DocumentModel.Drawings.ChartDrawing;

namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   User IShapes.
/// </summary>
public class UserShapes: ModelElement
{
  public RelativeAnchorSize? RelativeAnchorSize { get; set; }

  public AbsoluteAnchorSize? AbsoluteAnchorSize { get; set; }
}
