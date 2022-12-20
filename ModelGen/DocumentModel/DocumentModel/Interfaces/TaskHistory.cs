namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public partial interface TaskHistory
{
  public Collection<DocumentModel.TaskHistoryEvent>? TaskHistoryEvents { get; set; }
  
}
