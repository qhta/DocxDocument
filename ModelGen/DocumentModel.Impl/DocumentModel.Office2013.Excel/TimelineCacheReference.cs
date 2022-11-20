namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineCacheReference Class.
/// </summary>
public class TimelineCacheReference: ITimelineCacheReference
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
