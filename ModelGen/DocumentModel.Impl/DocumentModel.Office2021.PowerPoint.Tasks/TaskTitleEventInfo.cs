namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskTitleEventInfo Class.
/// </summary>
public class TaskTitleEventInfo: ITaskTitleEventInfo
{
  /// <summary>
  /// val, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
