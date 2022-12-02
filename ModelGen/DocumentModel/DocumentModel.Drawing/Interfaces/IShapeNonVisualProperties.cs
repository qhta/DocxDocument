namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface IShapeNonVisualProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public INonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
