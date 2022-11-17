namespace DocumentModel.Office.Drawing;

public interface IGroupShapeNonVisualProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office.Drawing.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }

  public DocumentModel.Office.Drawing.INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }

}
