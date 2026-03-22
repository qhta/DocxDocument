namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
public enum MsoSharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  msoSharedWorkspaceTaskStatusNotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  msoSharedWorkspaceTaskStatusInProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  msoSharedWorkspaceTaskStatusCompleted,
  /// <summary>
  /// Deferred.
  /// </summary>
  msoSharedWorkspaceTaskStatusDeferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  msoSharedWorkspaceTaskStatusWaiting
}
