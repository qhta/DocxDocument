namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Non-Visual Group Shape Drawing Properties.
/// </summary>
public interface INonVisualGroupShapeDrawingProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawing.IGroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.Drawing.INonVisualGroupDrawingShapePropsExtensionList? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
