namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface ShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
