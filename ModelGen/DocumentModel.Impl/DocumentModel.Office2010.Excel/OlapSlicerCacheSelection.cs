namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheSelection Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IOlapSlicerCacheItemParent))]
public class OlapSlicerCacheSelection: IOlapSlicerCacheSelection
{
  /// <summary>
  /// n, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
}
