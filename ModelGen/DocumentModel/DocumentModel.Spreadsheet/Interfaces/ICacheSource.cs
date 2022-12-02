namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSource Class.
/// </summary>
public interface ICacheSource // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IWorksheetSource? WorksheetSource { get ; set; }
  
  /// <summary>
  /// Consolidation.
  /// </summary>
  public IConsolidation? Consolidation { get ; set; }
  
  /// <summary>
  /// CacheSourceExtensionList.
  /// </summary>
  public ICacheSourceExtensionList? CacheSourceExtensionList { get ; set; }
  
}
