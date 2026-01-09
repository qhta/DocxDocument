namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes a graphic frame in chart drawings, including macro references, publishing options, non-visual properties, transformation settings, and contained graphical objects.
/// </summary>
public interface GraphicFrame
{
  /// <summary>
  /// Macro name or reference for custom functionality associated with the graphic frame.
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  /// Indicates whether the graphic frame should be published to a server or external destination.
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  /// Non-visual properties for the graphic frame, including identifiers, names, and metadata.
  /// </summary>
  public NonVisualGraphicFrameProperties? NonVisualGraphicFrameProperties { get; set; }

  /// <summary>
  /// Transformation settings for positioning, scaling, or rotating the graphic frame within the drawing canvas.
  /// </summary>
  public Transform? Transform { get; set; }

  /// <summary>
  /// Graphical object contained within the frame, such as charts, images, or diagrams.
  /// </summary>
  public Graphic? Graphic { get; set; }
}