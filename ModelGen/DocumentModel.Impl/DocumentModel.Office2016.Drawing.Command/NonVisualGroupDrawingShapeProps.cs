namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProps Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGroupDrawingShapePropsExtensionList))]
public class NonVisualGroupDrawingShapeProps: INonVisualGroupDrawingShapeProps
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
