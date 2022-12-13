namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface GroupShapeType
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
