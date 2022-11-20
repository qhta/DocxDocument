namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerCacheData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCache))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITabularSlicerCache))]
public class SlicerCacheData: ISlicerCacheData
{
  /// <summary>
  /// OlapSlicerCache.
  /// </summary>
  public IOlapSlicerCache? OlapSlicerCache
  {
    get;
    set;
  }
  
  /// <summary>
  /// TabularSlicerCache.
  /// </summary>
  public ITabularSlicerCache? TabularSlicerCache
  {
    get;
    set;
  }
  
}
