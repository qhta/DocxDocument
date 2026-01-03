namespace DocumentModel;

/// <summary>
///   Defines the TaskPriorityEventInfo Class.
/// </summary>
public interface TaskPriorityEventInfo: IModelElement
{
  /// <summary>
  ///   value
  /// </summary>
  public Int32? Value { get; set; }
}