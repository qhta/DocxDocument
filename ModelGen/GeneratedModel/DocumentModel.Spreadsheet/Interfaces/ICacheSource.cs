namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheSource Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICacheSourceExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IConsolidation))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IWorksheetSource))]
public interface ICacheSource // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// type
  /// </summary>
  public Source? Type { get ; set; }
  
  /// <summary>
  /// connectionId
  /// </summary>
  public uint? ConnectionId { get ; set; }
  
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
