namespace DocumentModel.Drawing.ChartDrawing;

public interface INonVisualConnectorShapeDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.ChartDrawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.ChartDrawing.INonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties { get ; set; }

}
