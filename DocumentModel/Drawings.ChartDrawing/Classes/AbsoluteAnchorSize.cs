namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Absolute Anchor Shape Size.
/// </summary>
public record AbsoluteAnchorSize
{
  /// <summary>
  ///   FromAnchor.
  /// </summary>
  public FromAnchor? FromAnchor { get; set; }

  /// <summary>
  ///   Shape Extent.
  /// </summary>
  public Extent? Extent { get; set; }

  public Shape? Shape { get; set; }

  public GroupShape? GroupShape { get; set; }

  public GraphicFrame? GraphicFrame { get; set; }

  public ConnectionShape? ConnectionShape { get; set; }

  public Picture? Picture { get; set; }
}