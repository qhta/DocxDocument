namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the GroupShapeNonVisualProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.INonVisualGroupDrawingShapeProperties))]
public interface IGroupShapeNonVisualProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
}
