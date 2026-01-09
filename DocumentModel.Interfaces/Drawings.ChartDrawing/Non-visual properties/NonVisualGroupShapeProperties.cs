namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a group shape in chart drawings, including general drawing properties and group-specific drawing settings.
/// </summary>
public interface NonVisualGroupShapeProperties
{
  /// <summary>
  /// General non-visual properties for the group shape, such as identifier, name, and metadata.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  /// Non-visual drawing properties specific to the group shape, including locking options and extension data.
  /// </summary>
  public NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get; set; }
}