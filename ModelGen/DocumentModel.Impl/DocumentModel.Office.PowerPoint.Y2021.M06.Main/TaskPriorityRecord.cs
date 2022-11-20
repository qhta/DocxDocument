namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskPriorityRecord Class.
/// </summary>
public class TaskPriorityRecord: ITaskPriorityRecord
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public int? Val
  {
    get;
    set;
  }
  
}
