namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtension Class.
/// </summary>
public interface IPivotCacheDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotCacheDecoupled? PivotCacheDecoupled { get ; set; }
  
  public DocumentModel.Spreadsheet.ITimelinePivotCacheDefinition? TimelinePivotCacheDefinition { get ; set; }
  
  public DocumentModel.Spreadsheet.IPivotCacheIdVersion? PivotCacheIdVersion { get ; set; }
  
  public System.String? Xsdboolean { get ; set; }
  
  public DocumentModel.Spreadsheet.ICacheVersionInfo? CacheVersionInfo { get ; set; }
  
}
