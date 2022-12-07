namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface ShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties1? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
