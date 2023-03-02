namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Group Shape Drawing Properties.
/// </summary>
public record NonVisualGroupShapeDrawingProperties
{
  /// <summary>
  ///   GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks { get; set; }

  /// <summary>
  ///   NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get; set; }
}