namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Page Breaks.
/// </summary>
public interface RowBreaks // : DocumentModel.Spreadsheet.PageBreakType
{
  public Collection<Break>? Breaks { get ; set; }
  
}
