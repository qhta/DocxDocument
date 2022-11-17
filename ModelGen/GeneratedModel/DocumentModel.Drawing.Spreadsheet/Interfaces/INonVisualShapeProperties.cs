namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Drawing.Spreadsheet.INonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties { get ; set; }
  
}
