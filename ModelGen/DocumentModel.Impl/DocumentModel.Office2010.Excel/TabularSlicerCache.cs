namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the TabularSlicerCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.ITabularSlicerCacheItems))]
public class TabularSlicerCache: ITabularSlicerCache
{
  /// <summary>
  /// pivotCacheId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? PivotCacheId
  {
    get;
    set;
  }
  
  /// <summary>
  /// sortOrder, this property is only available in Office 2010 and later.
  /// </summary>
  public TabularSlicerCacheSortOrderValues? SortOrder
  {
    get;
    set;
  }
  
  /// <summary>
  /// customListSort, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? CustomListSort
  {
    get;
    set;
  }
  
  /// <summary>
  /// showMissing, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowMissing
  {
    get;
    set;
  }
  
  /// <summary>
  /// crossFilter, this property is only available in Office 2010 and later.
  /// </summary>
  public SlicerCacheCrossFilterValues? CrossFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// TabularSlicerCacheItems.
  /// </summary>
  public ITabularSlicerCacheItems? TabularSlicerCacheItems
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
