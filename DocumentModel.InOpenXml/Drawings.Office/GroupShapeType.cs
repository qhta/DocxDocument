namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public class GroupShapeType: ModelElement
{
  /// <summary>
  ///   GroupShapeNonVisualProperties.
  /// </summary>
  public GroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get; set; }
  /// <summary>
  ///   GroupShapeProperties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }
}