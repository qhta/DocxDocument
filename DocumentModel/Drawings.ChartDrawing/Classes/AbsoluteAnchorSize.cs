namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Absolute Anchor Shape Size.
/// </summary>
public class AbsoluteAnchorSize: ModelElement
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