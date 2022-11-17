namespace DocumentModel.Drawing.Spreadsheet;

public interface INonVisualConnectionShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Drawing.Spreadsheet.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Drawing.Spreadsheet.INonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties { get ; set; }

}
