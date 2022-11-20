namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelinePivotCacheDefinition Class.
/// </summary>
public class TimelinePivotCacheDefinition: ITimelinePivotCacheDefinition
{
  /// <summary>
  /// timelineData, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? TimelineData
  {
    get;
    set;
  }
  
}
