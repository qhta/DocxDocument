namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.ChartDrawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }

}
