namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a group shape in chart drawings, including locking options and extension data for group-level settings.
/// </summary>
public interface NonVisualGroupShapeDrawingProperties
{
  /// <summary>
  /// Specifies locking options that restrict editing or manipulation of the group shape.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks { get; set; }

  /// <summary>
  /// Extension list for additional or future non-visual group shape properties.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get; set; }
}