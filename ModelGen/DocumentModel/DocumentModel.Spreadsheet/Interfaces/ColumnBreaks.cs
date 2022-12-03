namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Page Breaks.
/// </summary>
public interface ColumnBreaks // : DocumentModel.Spreadsheet.PageBreakType
{
  public Collection<Break>? Breaks { get ; set; }
  
}
