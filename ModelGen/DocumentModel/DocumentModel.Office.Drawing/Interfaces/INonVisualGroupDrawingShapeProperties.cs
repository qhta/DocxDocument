namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the NonVisualGroupDrawingShapeProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGroupShapeLocks))]
[ChildElementInfo(typeof(DocumentModel.Drawing.INonVisualGroupDrawingShapePropsExtensionList))]
public interface INonVisualGroupDrawingShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
