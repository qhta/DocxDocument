namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface IShapeNonVisualProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
