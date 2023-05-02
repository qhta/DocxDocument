namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TaskUndo Class.
/// </summary>
public class TaskUndo: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get; set; }
}