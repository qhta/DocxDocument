namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of the synchronization of the local copy of the active document with the server copy.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncstatustype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSyncStatusType")]
public enum SyncStatusType
{
  /// <summary>
  /// No shared workspace.
  /// </summary>
  [InteropEnumValue("msoSyncStatusNoSharedWorkspace")]
  NoSharedWorkspace = 0,
  /// <summary>
  /// No syncronization is needed.
  /// </summary>
  [InteropEnumValue("msoSyncStatusNotRoaming")]
  NotRoaming = 0,
  /// <summary>
  /// Documents are already in sync.
  /// </summary>
  [InteropEnumValue("msoSyncStatusLatest")]
  Latest = 1,
  /// <summary>
  /// Only server copy has changes.
  /// </summary>
  [InteropEnumValue("msoSyncStatusNewerAvailable")]
  NewerAvailable = 2,
  /// <summary>
  /// Only local copy has changes.
  /// </summary>
  [InteropEnumValue("msoSyncStatusLocalChanges")]
  LocalChanges = 3,
  /// <summary>
  /// Both the local and the server copies have changes.
  /// </summary>
  [InteropEnumValue("msoSyncStatusConflict")]
  Conflict = 4,
  /// <summary>
  /// Synchronization was suspended. You can use the Unsuspend method of the Sync object to resume synchronization.
  /// </summary>
  [InteropEnumValue("msoSyncStatusSuspended")]
  Suspended = 5,
  /// <summary>
  /// An error occurred. Use ErrorType property of Sync object to determine exact error.
  /// </summary>
  [InteropEnumValue("msoSyncStatusError")]
  Error = 6
}
