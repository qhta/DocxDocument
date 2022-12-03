namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSource Class.
/// </summary>
public interface CacheSource // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// type
  /// </summary>
  public SourceKind? Type { get ; set; }
  
  /// <summary>
  /// connectionId
  /// </summary>
  public UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// WorksheetSource.
  /// </summary>
  public WorksheetSource? WorksheetSource { get ; set; }
  
  /// <summary>
  /// Consolidation.
  /// </summary>
  public Consolidation? Consolidation { get ; set; }
  
  /// <summary>
  /// CacheSourceExtensionList.
  /// </summary>
  public CacheSourceExtensionList? CacheSourceExtensionList { get ; set; }
  
}
