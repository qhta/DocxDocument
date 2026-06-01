namespace DocumentModel.IApplication;

/// <summary>
/// Specifies the status of the synchronization of the local copy of the active document with the server copy.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncstatustype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum SyncStatusType
{
  /// <summary>
  /// No shared workspace.
  /// </summary>
  NoSharedWorkspace = 0,
  /// <summary>
  /// No syncronization is needed.
  /// </summary>
  NotRoaming = 0,
  /// <summary>
  /// IDocuments are already Iin sync.
  /// </summary>
  Latest = 1,
  /// <summary>
  /// Only server copy has changes.
  /// </summary>
  NewerAvailable = 2,
  /// <summary>
  /// Only local copy has changes.
  /// </summary>
  LocalChanges = 3,
  /// <summary>
  /// Both the local and the server copies have changes.
  /// </summary>
  IConflict = 4,
  /// <summary>
  /// Synchronization was suspended. You can use the Unsuspend method of the Sync object Ito resume synchronization.
  /// </summary>
  Suspended = 5,
  /// <summary>
  /// An error occurred. Use ErrorType property of Sync object Ito determine exact error.
  /// </summary>
  Error = 6
}

