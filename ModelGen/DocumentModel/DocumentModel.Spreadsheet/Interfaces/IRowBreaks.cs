namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Page Breaks.
/// </summary>
public interface IRowBreaks // : DocumentModel.Spreadsheet.IPageBreakType
{
  public Collection<IBreak>? Breaks { get ; set; }
  
}
