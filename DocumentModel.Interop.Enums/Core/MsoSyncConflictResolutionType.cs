namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies how conflicts should be resolved when synchronizing a shared document.
/// </summary>
public enum MsoSyncConflictResolutionType
{
  /// <summary>
  /// Specifies how conflicts should be resolved when synchronizing a shared document.
  /// </summary>
  msoSyncConflictClientWins,
  /// <summary>
  /// Specifies how conflicts should be resolved when synchronizing a shared document.
  /// </summary>
  msoSyncConflictServerWins,
  /// <summary>
  /// Merge changes made to the server copy into the local copy. In order to resolve the conflict with the merged
  /// changes winning, you must save the active document after merging changes, then call the ResolveConflict method
  /// again with the msoSyncConflictClientWins option.
  /// </summary>
  msoSyncConflictMerge
}
