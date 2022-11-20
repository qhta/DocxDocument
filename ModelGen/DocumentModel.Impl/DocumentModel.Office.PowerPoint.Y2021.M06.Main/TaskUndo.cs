namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskUndo Class.
/// </summary>
public class TaskUndo: ITaskUndo
{
  /// <summary>
  /// id, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
