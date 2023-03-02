namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
///   Defines the WordprocessingGroupType Class.
/// </summary>
public record WordprocessingGroupType
{
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }

  /// <summary>
  ///   NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }

  /// <summary>
  ///   GroupShapeProperties.
  /// </summary>
  public GroupShapeProperties? GroupShapeProperties { get; set; }
}