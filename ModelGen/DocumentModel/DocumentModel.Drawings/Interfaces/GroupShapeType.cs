namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeType Class.
/// </summary>
public interface GroupShapeType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
