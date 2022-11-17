namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public interface IPageMargins // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public double? L { get ; set; }

  public double? R { get ; set; }

  public double? T { get ; set; }

  public double? B { get ; set; }

  public double? Header { get ; set; }

  public double? Footer { get ; set; }

}
