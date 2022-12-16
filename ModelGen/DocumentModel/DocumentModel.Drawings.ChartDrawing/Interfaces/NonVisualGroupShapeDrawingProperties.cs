namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public interface NonVisualGroupShapeDrawingProperties
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawings.GroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
