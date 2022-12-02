namespace DocumentModel;

/// <summary>
/// Defines the TaskPriorityEventInfo Class.
/// </summary>
public interface ITaskPriorityEventInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// value, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? Value { get ; set; }
  
}
