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
  
  public DocumentModel.Office2010.Excel.IPivotCacheDefinition? PivotCacheDefinition { get ; set; }
  
  public DocumentModel.Office2013.Excel.IPivotCacheDecoupled? PivotCacheDecoupled { get ; set; }
  
  public DocumentModel.Office2013.Excel.ITimelinePivotCacheDefinition? TimelinePivotCacheDefinition { get ; set; }
  
  public DocumentModel.Office2013.Excel.IPivotCacheIdVersion? PivotCacheIdVersion { get ; set; }
  
  public System.String? Xsdboolean { get ; set; }
  
  public DocumentModel.Office.SpreadSheetML.Y2022.PivotVersionInfo.ICacheVersionInfo? CacheVersionInfo { get ; set; }
  
}
