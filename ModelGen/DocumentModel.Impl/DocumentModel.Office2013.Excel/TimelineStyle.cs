namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineStyle Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ITimelineStyleElements))]
public class TimelineStyle: ITimelineStyle
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// TimelineStyleElements.
  /// </summary>
  public ITimelineStyleElements? TimelineStyleElements
  {
    get;
    set;
  }
  
}
