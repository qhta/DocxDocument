namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Task Class.
/// </summary>
public class Task: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor { get; set; }

  /// <summary>
  ///   TaskHistory.
  /// </summary>
  public TaskHistory? TaskHistory { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}