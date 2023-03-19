namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
public class ShapeNonVisualProperties: ModelElement
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   NonVisualDrawingShapeProperties.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get; set; }
}