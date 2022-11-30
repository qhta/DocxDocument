namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Records.
/// </summary>
public interface IPivotCacheRecords // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// PivotCache Records Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IPivotCacheRecord>? PivotCacheRecords { get ; set; }
  
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
