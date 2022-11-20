namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the SlicerCacheHideItemsWithNoData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISlicerCacheOlapLevelName))]
public class SlicerCacheHideItemsWithNoData: ISlicerCacheHideItemsWithNoData
{
  /// <summary>
  /// count, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
