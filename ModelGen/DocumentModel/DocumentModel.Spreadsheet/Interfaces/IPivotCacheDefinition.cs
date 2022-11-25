namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Definition.
/// </summary>
public interface IPivotCacheDefinition // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// invalid
  /// </summary>
  public System.Boolean? Invalid { get ; set; }
  
  /// <summary>
  /// saveData
  /// </summary>
  public System.Boolean? SaveData { get ; set; }
  
  /// <summary>
  /// refreshOnLoad
  /// </summary>
  public System.Boolean? RefreshOnLoad { get ; set; }
  
  /// <summary>
  /// optimizeMemory
  /// </summary>
  public System.Boolean? OptimizeMemory { get ; set; }
  
  /// <summary>
  /// enableRefresh
  /// </summary>
  public System.Boolean? EnableRefresh { get ; set; }
  
  /// <summary>
  /// refreshedBy
  /// </summary>
  public System.String? RefreshedBy { get ; set; }
  
  /// <summary>
  /// refreshedDateIso
  /// </summary>
  public System.DateTime? LastRefreshedDateIso { get ; set; }
  
  /// <summary>
  /// refreshedDate
  /// </summary>
  public System.Double? RefreshedDate { get ; set; }
  
  /// <summary>
  /// backgroundQuery
  /// </summary>
  public System.Boolean? BackgroundQuery { get ; set; }
  
  /// <summary>
  /// missingItemsLimit
  /// </summary>
  public System.UInt32? MissingItemsLimit { get ; set; }
  
  /// <summary>
  /// createdVersion
  /// </summary>
  public System.Byte? CreatedVersion { get ; set; }
  
  /// <summary>
  /// refreshedVersion
  /// </summary>
  public System.Byte? RefreshedVersion { get ; set; }
  
  /// <summary>
  /// minRefreshableVersion
  /// </summary>
  public System.Byte? MinRefreshableVersion { get ; set; }
  
  /// <summary>
  /// recordCount
  /// </summary>
  public System.UInt32? RecordCount { get ; set; }
  
  /// <summary>
  /// upgradeOnRefresh
  /// </summary>
  public System.Boolean? UpgradeOnRefresh { get ; set; }
  
  /// <summary>
  /// tupleCache
  /// </summary>
  public System.Boolean? IsTupleCache { get ; set; }
  
  /// <summary>
  /// supportSubquery
  /// </summary>
  public System.Boolean? SupportSubquery { get ; set; }
  
  /// <summary>
  /// supportAdvancedDrill
  /// </summary>
  public System.Boolean? SupportAdvancedDrill { get ; set; }
  
  /// <summary>
  /// CacheSource.
  /// </summary>
  public DocumentModel.Spreadsheet.ICacheSource? CacheSource { get ; set; }
  
  /// <summary>
  /// CacheFields.
  /// </summary>
  public DocumentModel.Spreadsheet.ICacheFields? CacheFields { get ; set; }
  
  /// <summary>
  /// CacheHierarchies.
  /// </summary>
  public DocumentModel.Spreadsheet.ICacheHierarchies? CacheHierarchies { get ; set; }
  
  /// <summary>
  /// Kpis.
  /// </summary>
  public DocumentModel.Spreadsheet.IKpis? Kpis { get ; set; }
  
  /// <summary>
  /// TupleCache.
  /// </summary>
  public DocumentModel.Spreadsheet.ITupleCache? TupleCache { get ; set; }
  
  /// <summary>
  /// CalculatedItems.
  /// </summary>
  public DocumentModel.Spreadsheet.ICalculatedItems? CalculatedItems { get ; set; }
  
  /// <summary>
  /// CalculatedMembers.
  /// </summary>
  public DocumentModel.Spreadsheet.ICalculatedMembers? CalculatedMembers { get ; set; }
  
  /// <summary>
  /// Dimensions.
  /// </summary>
  public DocumentModel.Spreadsheet.IDimensions? Dimensions { get ; set; }
  
  /// <summary>
  /// MeasureGroups.
  /// </summary>
  public DocumentModel.Spreadsheet.IMeasureGroups? MeasureGroups { get ; set; }
  
  /// <summary>
  /// Maps.
  /// </summary>
  public DocumentModel.Spreadsheet.IMaps? Maps { get ; set; }
  
  /// <summary>
  /// PivotCacheDefinitionExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? PivotCacheDefinitionExtensionList { get ; set; }
  
}
