namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IRichTextBody // : DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TextBodyType
{
  public IBodyProperties? BodyProperties { get ; set; }

  public IListStyle? ListStyle { get ; set; }

}
