namespace DocumentModel.Office.Drawing;

public interface IShapeTree // : DocumentFormat.OpenXml.Office.Drawing.GroupShapeType
{
  public IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }

  public DocumentModel.Office.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }

}
