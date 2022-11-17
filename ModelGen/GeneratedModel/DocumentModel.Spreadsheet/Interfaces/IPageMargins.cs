namespace DocumentModel.Spreadsheet;

public interface IPageMargins // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public double? Left { get ; set; }

  public double? Right { get ; set; }

  public double? Top { get ; set; }

  public double? Bottom { get ; set; }

  public double? Header { get ; set; }

  public double? Footer { get ; set; }

}
