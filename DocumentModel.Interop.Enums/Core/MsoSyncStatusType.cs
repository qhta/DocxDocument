namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of the synchronization of the local copy of the active document with the server copy.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncstatustype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSyncStatusType))]
public enum SyncStatusType
{
  /// <summary>
  /// No shared workspace.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusNoSharedWorkspace))]
  NoSharedWorkspace = 0,
  /// <summary>
  /// No syncronization is needed.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusNotRoaming))]
  NotRoaming = 0,
  /// <summary>
  /// Documents are already in sync.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusLatest))]
  Latest = 1,
  /// <summary>
  /// Only server copy has changes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusNewerAvailable))]
  NewerAvailable = 2,
  /// <summary>
  /// Only local copy has changes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusLocalChanges))]
  LocalChanges = 3,
  /// <summary>
  /// Both the local and the server copies have changes.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusConflict))]
  Conflict = 4,
  /// <summary>
  /// Synchronization was suspended. You can use the Unsuspend method of the Sync object to resume synchronization.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusSuspended))]
  Suspended = 5,
  /// <summary>
  /// An error occurred. Use ErrorType property of Sync object to determine exact error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSyncStatusType.msoSyncStatusError))]
  Error = 6
}
