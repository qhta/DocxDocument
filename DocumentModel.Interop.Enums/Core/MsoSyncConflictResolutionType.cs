namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how conflicts should be resolved when synchronizing a shared document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosyncconflictresolutiontype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoSyncConflictResolutionType
{
  /// <summary>
  /// Specifies how conflicts should be resolved when synchronizing a shared document.
  /// </summary>
  ClientWins,
  /// <summary>
  /// Specifies how conflicts should be resolved when synchronizing a shared document.
  /// </summary>
  ServerWins,
  /// <summary>
  /// Merge changes made to the server copy into the local copy. In order to resolve the conflict with the merged
  /// changes winning, you must save the active document after merging changes, then call the ResolveConflict method
  /// again with the msoSyncConflictClientWins option.
  /// </summary>
  Merge
}
