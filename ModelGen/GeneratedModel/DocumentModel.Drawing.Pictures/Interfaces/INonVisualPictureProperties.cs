namespace DocumentModel.Drawing.Pictures;

public interface INonVisualPictureProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Pictures.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.Pictures.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }

}
