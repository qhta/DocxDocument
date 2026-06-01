namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Absolute Anchor IShape Size.
/// </summary>
public class AbsoluteAnchorSize: ModelElement
{
  /// <summary>
  ///   FromAnchor.
  /// </summary>
  public FromAnchor? FromAnchor { get; set; }

  /// <summary>
  ///   IShape Extent.
  /// </summary>
  public Extent? Extent { get; set; }

  public IShape? IShape { get; set; }

  public GroupShape? GroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public ConnectionShape? ConnectionShape { get; set; }

  public Picture? Picture { get; set; }
}
