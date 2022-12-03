namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public interface NonVisualGroupShapeDrawingProperties // : DocumentModel.BaseTypes.ModelElement
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
