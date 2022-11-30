namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSource Class.
/// </summary>
public interface ICacheSource // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Spreadsheet.SourceKind? Type { get ; set; }
  
  /// <summary>
  /// connectionId
  /// </summary>
  public System.UInt32? ConnectionId { get ; set; }
  
  /// <summary>
  /// WorksheetSource.
  /// </summary>
  public DocumentModel.Spreadsheet.IWorksheetSource? WorksheetSource { get ; set; }
  
  /// <summary>
  /// Consolidation.
  /// </summary>
  public DocumentModel.Spreadsheet.IConsolidation? Consolidation { get ; set; }
  
  /// <summary>
  /// CacheSourceExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.ICacheSourceExtensionList? CacheSourceExtensionList { get ; set; }
  
}
