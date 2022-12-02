namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface IGroupShapeType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Drawing.IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
