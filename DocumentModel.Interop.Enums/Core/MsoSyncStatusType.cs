namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of the synchronization of the local copy of the active document with the server copy.
/// </summary>
public enum MsoSyncStatusType
{
  /// <summary>
  /// Specifies the status of the synchronization of the local copy of the active document with the server copy.
  /// </summary>
  msoSyncStatusNoSharedWorkspace = 0,
  /// <summary>
  /// No syncronization is needed.
  /// </summary>
  msoSyncStatusNotRoaming = 0,
  /// <summary>
  /// Documents are already in sync.
  /// </summary>
  msoSyncStatusLatest = 1,
  /// <summary>
  /// Only server copy has changes.
  /// </summary>
  msoSyncStatusNewerAvailable = 2,
  /// <summary>
  /// Only local copy has changes.
  /// </summary>
  msoSyncStatusLocalChanges = 3,
  /// <summary>
  /// Both the local and the server copies have changes.
  /// </summary>
  msoSyncStatusConflict = 4,
  /// <summary>
  /// Synchronization was suspended. You can use the Unsuspend method of the Sync object to resume synchronization.
  /// </summary>
  msoSyncStatusSuspended = 5,
  /// <summary>
  /// An error occurred. Use ErrorType property of Sync object to determine exact error.
  /// </summary>
  msoSyncStatusError = 6
}
