namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Non-Visual Shape Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.INonVisualShapeDrawingProperties))]
public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Chart Non Visual Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Non-Visual Shape Drawing Properties.
  /// </summary>
  public DocumentModel.Drawing.ChartDrawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
