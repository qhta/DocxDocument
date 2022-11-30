namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Page Breaks.
/// </summary>
public interface IRowBreaks // : DocumentModel.Spreadsheet.IPageBreakType
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IBreak>? Breaks { get ; set; }
  
}
