namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Records.
/// </summary>
public interface IPivotCacheRecords // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// PivotCache Records Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPivotCacheRecord>? PivotCacheRecords { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
