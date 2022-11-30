namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Page Breaks.
/// </summary>
public interface IColumnBreaks // : DocumentModel.Spreadsheet.IPageBreakType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IBreak>? Breaks { get ; set; }
  
}
