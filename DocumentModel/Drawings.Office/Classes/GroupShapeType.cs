namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the GroupShapeType Class.
/// </summary>
public record GroupShapeType
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