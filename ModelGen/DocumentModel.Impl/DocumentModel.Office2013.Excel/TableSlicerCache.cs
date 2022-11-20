namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TableSlicerCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
public class TableSlicerCache: ITableSlicerCache
{
  /// <summary>
  /// tableId, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? TableId
  {
    get;
    set;
  }
  
  /// <summary>
  /// column, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Column
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
  /// customListSort, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? CustomListSort
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
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
