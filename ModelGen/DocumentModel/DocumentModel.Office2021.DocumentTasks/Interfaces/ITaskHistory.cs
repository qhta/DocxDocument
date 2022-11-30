namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public interface ITaskHistory // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2021.DocumentTasks.ITaskHistoryEvent>? TaskHistoryEvents { get ; set; }
  
}
