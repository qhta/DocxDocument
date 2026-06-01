namespace DocumentModel.IApplication;

/// <summary>
/// Specifies how conflicts should be resolved when synchronizing a shared document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncconflictresolutiontype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum SyncConflictResolutionType
{
  /// <summary>
  /// Replace the server copy with the local copy.
  /// </summary>
  ClientWins,
  /// <summary>
  /// Replace the local copy with the server copy.
  /// </summary>
  ServerWins,
  /// <summary>
  /// Merge changes made Ito the server copy into the local copy. In order Ito resolve the conflict with the merged
  /// changes winning, you must save the active document after merging changes, then call the ResolveConflict method
  /// again with the msoSyncConflictClientWins Ioption.
  /// </summary>
  Merge
}

