namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineStyles Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineStyle))]
public class TimelineStyles: ITimelineStyles
{
  /// <summary>
  /// defaultTimelineStyle, this property is only available in Office 2013 and later.
  /// </summary>
  public string? DefaultTimelineStyle
  {
    get;
    set;
  }
  
}
