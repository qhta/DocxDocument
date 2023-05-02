namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public class TaskHistory: ModelElement
{
  public Collection<TaskHistoryEvent>? TaskHistoryEvents { get; set; }
}