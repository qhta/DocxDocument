namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualGroupShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.Spreadsheet.INonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties { get ; set; }

}
