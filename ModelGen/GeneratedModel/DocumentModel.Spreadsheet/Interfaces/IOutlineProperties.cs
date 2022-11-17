namespace DocumentModel.Spreadsheet;

public interface IOutlineProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? ApplyStyles { get ; set; }

  public bool? SummaryBelow { get ; set; }

  public bool? SummaryRight { get ; set; }

  public bool? ShowOutlineSymbols { get ; set; }

}
