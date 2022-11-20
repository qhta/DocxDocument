namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the OlapSlicerCacheItemParent Class.
/// </summary>
public class OlapSlicerCacheItemParent: IOlapSlicerCacheItemParent
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
