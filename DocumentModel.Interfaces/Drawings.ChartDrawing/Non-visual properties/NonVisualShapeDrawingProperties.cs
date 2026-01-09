namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Describes non-visual properties for a shape in chart drawings, including text box indication, locking options, and extension data.
/// </summary>
public interface NonVisualShapeDrawingProperties: ExtendableElement
{
  /// <summary>
  /// Indicates whether the shape functions as a text box within the drawing.
  /// </summary>
  public bool? TextBox { get; set; }

  /// <summary>
  /// Specifies locking options that restrict editing or manipulation of the shape.
  /// </summary>
  public ShapeLocks? ShapeLocks { get; set; }
}