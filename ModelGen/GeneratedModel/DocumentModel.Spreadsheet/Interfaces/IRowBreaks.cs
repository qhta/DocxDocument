namespace DocumentModel.Spreadsheet;

public interface IRowBreaks // : DocumentFormat.OpenXml.Spreadsheet.PageBreakType
{
  public uint? Count { get ; set; }
  
  public uint? ManualBreakCount { get ; set; }
  
}
