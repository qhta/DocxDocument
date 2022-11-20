namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the BoundsTimelineRange Class.
/// </summary>
public class BoundsTimelineRange: IBoundsTimelineRange
{
  /// <summary>
  /// startDate, this property is only available in Office 2013 and later.
  /// </summary>
  public DateTime? StartDate
  {
    get;
    set;
  }
  
  /// <summary>
  /// endDate, this property is only available in Office 2013 and later.
  /// </summary>
  public DateTime? EndDate
  {
    get;
    set;
  }
  
}
