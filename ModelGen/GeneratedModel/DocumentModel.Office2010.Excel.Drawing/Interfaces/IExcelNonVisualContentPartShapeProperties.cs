namespace DocumentModel.Office2010.Excel.Drawing;

public interface IExcelNonVisualContentPartShapeProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Excel.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Office2010.Excel.Drawing.INonVisualInkContentPartProperties? NonVisualInkContentPartProperties { get ; set; }

}
