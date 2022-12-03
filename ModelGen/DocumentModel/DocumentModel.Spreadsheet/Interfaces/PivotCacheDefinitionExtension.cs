namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtension Class.
/// </summary>
public interface PivotCacheDefinitionExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public PivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public PivotCacheDecoupled? PivotCacheDecoupled { get ; set; }
  
  public TimelinePivotCacheDefinition? TimelinePivotCacheDefinition { get ; set; }
  
  public PivotCacheIdVersion? PivotCacheIdVersion { get ; set; }
  
  public String? Xsdboolean { get ; set; }
  
  public CacheVersionInfo? CacheVersionInfo { get ; set; }
  
}
