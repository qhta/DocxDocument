namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public interface GroupShapeNonVisualProperties: IModelElement
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
}