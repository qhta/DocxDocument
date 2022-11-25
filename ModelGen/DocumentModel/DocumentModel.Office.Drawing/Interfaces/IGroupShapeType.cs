namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface IGroupShapeType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
