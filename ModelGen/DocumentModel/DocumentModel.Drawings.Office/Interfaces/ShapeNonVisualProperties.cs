namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface ShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
