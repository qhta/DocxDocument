namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheRange Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheItem))]
public class OlapSlicerCacheRange: IOlapSlicerCacheRange
{
  /// <summary>
  /// startItem, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? StartItem
  {
    get;
    set;
  }
  
}
