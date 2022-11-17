namespace DocumentModel.Drawing;

public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }

}
