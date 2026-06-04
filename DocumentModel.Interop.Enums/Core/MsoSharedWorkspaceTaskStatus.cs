namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskstatus?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus")]
public enum SharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskStatusNotStarted")]
  NotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskStatusInProgress")]
  InProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskStatusCompleted")]
  Completed,
  /// <summary>
  /// Deferred.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskStatusDeferred")]
  Deferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskStatusWaiting")]
  Waiting
}
