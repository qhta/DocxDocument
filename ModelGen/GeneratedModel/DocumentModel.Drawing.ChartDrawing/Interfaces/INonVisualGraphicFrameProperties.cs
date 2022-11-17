namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualGraphicFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}
