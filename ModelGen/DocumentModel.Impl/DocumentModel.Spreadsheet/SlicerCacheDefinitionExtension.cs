namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerCacheDefinitionExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISlicerCachePivotTables))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISlicerCacheHideItemsWithNoData))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITableSlicerCache))]
public class SlicerCacheDefinitionExtension: ISlicerCacheDefinitionExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
