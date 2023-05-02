namespace DocumentModel.Drawings.Office;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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