namespace DocumentModel;

/// <summary>
/// Defines the TaskHistory Class.
/// </summary>
public interface ITaskHistory // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITaskHistoryEvent>? TaskHistoryEvents { get ; set; }
  
}
