namespace DocumentModel;

/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public interface TaskHistory: IModelElement
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get; set; }
}