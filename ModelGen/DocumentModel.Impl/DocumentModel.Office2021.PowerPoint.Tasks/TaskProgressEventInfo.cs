namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public class TaskProgressEventInfo: ITaskProgressEventInfo
{
  /// <summary>
  /// val, this property is only available in Office 2021 and later.
  /// </summary>
  public int? Val
  {
    get;
    set;
  }
  
}
