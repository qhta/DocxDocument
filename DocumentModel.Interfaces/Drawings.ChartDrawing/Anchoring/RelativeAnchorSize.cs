namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes the size and positioning of a shape anchored relative to other elements in chart drawings, including anchor points and contained graphical elements.
/// </summary>
public interface RelativeAnchorSize
{
  /// <summary>
  /// Starting anchor point for the shape within the drawing canvas.
  /// </summary>
  public FromAnchor? FromAnchor { get; set; }

  /// <summary>
  /// Ending anchor point for the shape within the drawing canvas.
  /// </summary>
  public ToAnchor? ToAnchor { get; set; }

  /// <summary>
  /// Shape element contained within the anchor.
  /// </summary>
  public Shape? Shape { get; set; }

  /// <summary>
  /// Group shape element contained within the anchor.
  /// </summary>
  public GroupShape? GroupShape { get; set; }

  /// <summary>
  /// Graphic frame element contained within the anchor.
  /// </summary>
  public GraphicFrame? GraphicFrame { get; set; }

  /// <summary>
  /// Connection shape element contained within the anchor.
  /// </summary>
  public ConnectionShape? ConnectionShape { get; set; }

  /// <summary>
  /// Picture element contained within the anchor.
  /// </summary>
  public Picture? Picture { get; set; }
}