namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public interface TaskHistory // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get ; set; }
  
}
