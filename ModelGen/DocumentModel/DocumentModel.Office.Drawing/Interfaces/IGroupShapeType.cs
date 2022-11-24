namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface IGroupShapeType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
