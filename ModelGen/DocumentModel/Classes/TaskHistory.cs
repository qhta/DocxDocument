namespace DocumentModel;


/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public partial class TaskHistory
{
  public DM.ElementCollection<TaskHistoryEvent>? Items { get; set; }
  
}
