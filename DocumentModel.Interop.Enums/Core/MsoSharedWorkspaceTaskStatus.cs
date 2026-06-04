namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskstatus?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus))]
public enum SharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus.msoSharedWorkspaceTaskStatusNotStarted))]
  NotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus.msoSharedWorkspaceTaskStatusInProgress))]
  InProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus.msoSharedWorkspaceTaskStatusCompleted))]
  Completed,
  /// <summary>
  /// Deferred.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus.msoSharedWorkspaceTaskStatusDeferred))]
  Deferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskStatus.msoSharedWorkspaceTaskStatusWaiting))]
  Waiting
}
