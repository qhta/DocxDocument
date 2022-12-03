namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PageBreakType Class.
/// </summary>
public interface PageBreakType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Page Break Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  /// <summary>
  /// Manual Break Count
  /// </summary>
  public UInt32? ManualBreakCount { get ; set; }
  
}
