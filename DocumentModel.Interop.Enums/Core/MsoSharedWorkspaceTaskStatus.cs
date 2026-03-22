namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
public enum MsoSharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  NotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  InProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  Completed,
  /// <summary>
  /// Deferred.
  /// </summary>
  Deferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  Waiting
}
