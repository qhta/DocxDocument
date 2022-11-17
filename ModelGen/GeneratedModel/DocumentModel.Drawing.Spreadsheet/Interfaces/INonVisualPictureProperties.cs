namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualPictureProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.Spreadsheet.INonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get ; set; }

}
