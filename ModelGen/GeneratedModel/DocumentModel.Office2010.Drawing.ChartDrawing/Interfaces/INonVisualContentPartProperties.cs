namespace DocumentModel.Office2010.Drawing.ChartDrawing;

public interface INonVisualContentPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Office2010.Drawing.ChartDrawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }
  
}
