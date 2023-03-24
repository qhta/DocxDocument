namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskPriorityEventInfo Class.
/// </summary>
public class TaskPriorityEventInfo: ModelElement
{
  /// <summary>
  ///   value, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? Value { get; set; }
}