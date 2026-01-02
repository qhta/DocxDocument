namespace DocumentModel;

/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public class TaskHistory: ModelElement
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get; set; }
}