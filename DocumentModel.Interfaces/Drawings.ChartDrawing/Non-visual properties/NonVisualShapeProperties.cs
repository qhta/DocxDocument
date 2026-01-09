namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a shape in chart drawings, including general drawing properties and shape-specific drawing settings.
/// </summary>
public interface NonVisualShapeProperties
{
  /// <summary>
  /// General non-visual properties for the shape, such as identifier, name, and metadata.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual drawing properties specific to the shape, including text box indication, locking options, and extension data.
  /// </summary>
  public NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get; set; }
}