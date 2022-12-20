namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public partial interface GroupShapeType
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.GroupShapeProperties? GroupShapeProperties { get; set; }
  
}
