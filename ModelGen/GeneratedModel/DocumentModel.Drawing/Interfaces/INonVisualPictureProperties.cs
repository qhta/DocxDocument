namespace DocumentModel.Drawing;

public interface INonVisualPictureProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }

}
