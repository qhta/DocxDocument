namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGroupDrawingShapePropsExtensionList))]
public class NonVisualGroupDrawingShapeProperties: INonVisualGroupDrawingShapeProperties
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
