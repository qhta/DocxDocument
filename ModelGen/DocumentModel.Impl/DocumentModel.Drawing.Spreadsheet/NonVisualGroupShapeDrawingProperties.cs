namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGroupDrawingShapePropsExtensionList))]
public class NonVisualGroupShapeDrawingProperties: INonVisualGroupShapeDrawingProperties
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public IGroupShapeLocks? GroupShapeLocks
  {
    get;
    set;
  }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList
  {
    get;
    set;
  }
  
}
