namespace DocumentModel;

/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public record TaskHistory
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get; set; }
}