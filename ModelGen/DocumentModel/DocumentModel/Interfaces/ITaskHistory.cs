namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public interface ITaskHistory // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.ITaskHistoryEvent>? TaskHistoryEvents { get ; set; }
  
}
