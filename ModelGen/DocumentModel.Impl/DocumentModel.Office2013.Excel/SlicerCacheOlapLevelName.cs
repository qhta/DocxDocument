namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the SlicerCacheOlapLevelName Class.
/// </summary>
public class SlicerCacheOlapLevelName: ISlicerCacheOlapLevelName
{
  /// <summary>
  /// uniqueName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? UniqueName
  {
    get;
    set;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
