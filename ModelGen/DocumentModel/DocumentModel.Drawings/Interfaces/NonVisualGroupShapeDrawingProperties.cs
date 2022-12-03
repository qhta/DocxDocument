namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public interface NonVisualGroupShapeDrawingProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public GroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public NonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
