namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
public interface INonVisualGroupDrawingShapeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// GroupShapeLocks.
  /// </summary>
  public DocumentModel.Drawing.IGroupShapeLocks? GroupShapeLocks { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapePropsExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? NonVisualGroupDrawingShapePropsExtensionList { get ; set; }
  
}
