namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotCacheDefinitionExtension Class.
/// </summary>
public interface IPivotCacheDefinitionExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IPivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public IPivotCacheDecoupled? PivotCacheDecoupled { get ; set; }
  
  public ITimelinePivotCacheDefinition? TimelinePivotCacheDefinition { get ; set; }
  
  public IPivotCacheIdVersion? PivotCacheIdVersion { get ; set; }
  
  public String? Xsdboolean { get ; set; }
  
  public ICacheVersionInfo? CacheVersionInfo { get ; set; }
  
}
