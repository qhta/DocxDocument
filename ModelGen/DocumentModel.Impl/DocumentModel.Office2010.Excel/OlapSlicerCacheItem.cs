namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheItem Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheItemParent))]
public class OlapSlicerCacheItem: IOlapSlicerCacheItem
{
  /// <summary>
  /// n, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// c, this property is only available in Office 2010 and later.
  /// </summary>
  public string? DisplayName
  {
    get;
    set;
  }
  
  /// <summary>
  /// nd, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NonDisplay
  {
    get;
    set;
  }
  
}
