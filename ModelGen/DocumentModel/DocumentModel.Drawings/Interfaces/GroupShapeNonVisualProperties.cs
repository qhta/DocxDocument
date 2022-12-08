namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public interface GroupShapeNonVisualProperties
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties2? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
}
