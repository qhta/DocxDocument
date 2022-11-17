namespace DocumentModel.Office2019.Excel.RichData2;

public interface IRichTop10 // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Key { get ; set; }

  public bool? Top { get ; set; }

  public bool? Percent { get ; set; }

  public double? Val { get ; set; }

  public double? FilterValue { get ; set; }

}
