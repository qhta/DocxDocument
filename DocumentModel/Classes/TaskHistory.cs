namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public partial class TaskHistory
{
  public Collection<DocumentModel.TaskHistoryEvent>? TaskHistoryEvents { get; set; }
  
}
