namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualPictureProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.ChartDrawing.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }
  
}
