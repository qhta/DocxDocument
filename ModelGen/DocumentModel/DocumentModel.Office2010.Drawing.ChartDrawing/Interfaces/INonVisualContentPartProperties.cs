namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the NonVisualContentPartProperties Class.
/// </summary>
public interface INonVisualContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
