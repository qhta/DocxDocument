namespace DocumentModel.Office.Drawing;

public interface IShapeNonVisualProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  public DocumentModel.Office.Drawing.INonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get ; set; }
  
}
