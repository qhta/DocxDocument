namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public interface GroupShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.NonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
}
