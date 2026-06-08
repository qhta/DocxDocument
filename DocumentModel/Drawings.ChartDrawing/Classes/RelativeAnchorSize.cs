namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Relative Anchor IShape Size.
/// </summary>
public class RelativeAnchorSize: ModelElement
{
  /// <summary>
  ///   Starting Anchor IPoint.
  /// </summary>
  public FromAnchor? FromAnchor { get; set; }

  /// <summary>
  ///   Ending Anchor IPoint.
  /// </summary>
  public ToAnchor? ToAnchor { get; set; }

  public IShape? IShape { get; set; }

  public GroupShape? GroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public ConnectionShape? ConnectionShape { get; set; }

  public Picture? Picture { get; set; }
}
