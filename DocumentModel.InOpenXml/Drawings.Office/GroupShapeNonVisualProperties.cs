namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public class GroupShapeNonVisualProperties: ModelElement<DXOD.GroupShapeNonVisualProperties>
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