namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualDrawingProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualInkContentPartProperties))]
public interface INonVisualContentPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualInkContentPartProperties.
  /// </summary>
  public DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
