namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskstatus?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSharedWorkspaceTaskStatus")]
public enum SharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  [OfficeInteropEnumValue("msoSharedWorkspaceTaskStatusNotStarted")]
  NotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  [OfficeInteropEnumValue("msoSharedWorkspaceTaskStatusInProgress")]
  InProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  [OfficeInteropEnumValue("msoSharedWorkspaceTaskStatusCompleted")]
  Completed,
  /// <summary>
  /// Deferred.
  /// </summary>
  [OfficeInteropEnumValue("msoSharedWorkspaceTaskStatusDeferred")]
  Deferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  [OfficeInteropEnumValue("msoSharedWorkspaceTaskStatusWaiting")]
  Waiting
}
