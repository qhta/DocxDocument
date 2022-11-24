namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProps Class.
/// </summary>
public interface INonVisualGroupDrawingShapeProps // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public IGroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
