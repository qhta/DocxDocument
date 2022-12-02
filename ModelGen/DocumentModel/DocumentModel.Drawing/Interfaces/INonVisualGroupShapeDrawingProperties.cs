namespace DocumentModel.Drawing;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public interface INonVisualGroupShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
