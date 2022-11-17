namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualGraphicFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.INonVisualGraphicFrameDrawingProperties? NonVisualGraphicFrameDrawingProperties { get ; set; }
  
}
