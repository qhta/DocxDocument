namespace DocumentModel;

/// <summary>
///   Defines the Task Class.
/// </summary>
public record Task
{
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }

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