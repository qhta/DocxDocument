namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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