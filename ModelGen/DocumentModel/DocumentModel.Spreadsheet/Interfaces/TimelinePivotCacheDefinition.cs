namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TimelinePivotCacheDefinition Class.
/// </summary>
public interface TimelinePivotCacheDefinition // : System.Boolean
{
  /// <summary>
  /// timelineData, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? TimelineData { get ; set; }
  
}
