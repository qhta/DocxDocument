namespace DocumentModel.Drawing;

public interface INonVisualConnectionShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }

}
