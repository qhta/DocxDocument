namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Page Breaks.
/// </summary>
public interface IColumnBreaks // : DocumentModel.Spreadsheet.IPageBreakType
{
  public Collection<IBreak>? Breaks { get ; set; }
  
}
