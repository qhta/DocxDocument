namespace DocumentModel.Wordprocessing.DrawingGroup;

/// <summary>
/// Defines the WordprocessingGroupType Class.
/// </summary>
public partial class WordprocessingGroupType
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.NonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingGroup.GroupShapeProperties? GroupShapeProperties { get; set; }
  
}
