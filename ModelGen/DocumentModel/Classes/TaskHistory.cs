namespace DocumentModel;


/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public partial class TaskHistory
{
  public DocumentModel.ElementCollection<DocumentModel.TaskHistoryEvent>? Items { get; set; }
  
}
