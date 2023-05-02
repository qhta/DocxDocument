namespace DocumentModel.Wordprocessing.DrawingGroup;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WordprocessingGroupType Class.
/// </summary>
public class WordprocessingGroupType: ModelElement
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