namespace DocumentModel.Spreadsheet;

/// <summary>
/// Horizontal Page Breaks.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IBreak))]
public interface IRowBreaks // : DocumentFormat.OpenXml.Spreadsheet.PageBreakType
{
  /// <summary>
  /// Page Break Count
  /// </summary>
  public uint? Count { get ; set; }
  
  /// <summary>
  /// Manual Break Count
  /// </summary>
  public uint? ManualBreakCount { get ; set; }
  
}
