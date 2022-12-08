namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public interface TaskHistory
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get ; set; }
  
}
