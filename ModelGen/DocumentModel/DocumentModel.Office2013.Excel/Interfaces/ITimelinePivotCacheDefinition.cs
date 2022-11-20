namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelinePivotCacheDefinition Class.
/// </summary>
public interface ITimelinePivotCacheDefinition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// timelineData, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? TimelineData { get ; set; }
  
}
