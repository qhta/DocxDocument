namespace DocumentModel.Spreadsheet;

/// <summary>
/// Vertical Page Breaks.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBreak))]
public class ColumnBreaks: IColumnBreaks
{
  /// <summary>
  /// Page Break Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Manual Break Count
  /// </summary>
  public uint? ManualBreakCount
  {
    get;
    set;
  }
  
}
