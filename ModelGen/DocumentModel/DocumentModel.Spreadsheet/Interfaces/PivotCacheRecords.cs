namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Records.
/// </summary>
public interface PivotCacheRecords // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// PivotCache Records Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<PivotCacheRecord>? PivotCacheRecords { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
