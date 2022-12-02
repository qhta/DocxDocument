namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
public interface IGroupShapeNonVisualProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
}
