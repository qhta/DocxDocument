namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a graphic frame in chart drawings, including general drawing properties and frame-specific drawing settings.
/// </summary>
public interface NonVisualGraphicFrameProperties
{
  /// <summary>
  /// General non-visual properties for the graphic frame, such as identifier, name, and metadata.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual drawing properties specific to the graphic frame, including locking and editing restrictions.
  /// </summary>
  public NonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get; set; }
}