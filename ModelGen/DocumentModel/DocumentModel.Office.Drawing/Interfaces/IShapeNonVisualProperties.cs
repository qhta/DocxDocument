namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the ShapeNonVisualProperties Class.
/// </summary>
public interface IShapeNonVisualProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
