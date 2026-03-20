using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Sync` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia
/// </remarks>
public partial interface Sync
{
  /// <summary>
  /// Invokes `GetUpdate`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.getupdate?view=office-pia
  /// </remarks>
  public void GetUpdate();
  /// <summary>
  /// Invokes `PutUpdate`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.putupdate?view=office-pia
  /// </remarks>
  public void PutUpdate();
  /// <summary>
  /// Invokes `OpenVersion`.
  /// </summary>
  /// <param name="SyncVersionType">The `SyncVersionType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.openversion?view=office-pia
  /// </remarks>
  public void OpenVersion(MsoSyncVersionType SyncVersionType);
  /// <summary>
  /// Invokes `ResolveConflict`.
  /// </summary>
  /// <param name="SyncConflictResolution">The `SyncConflictResolution` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.resolveconflict?view=office-pia
  /// </remarks>
  public void ResolveConflict(MsoSyncConflictResolutionType SyncConflictResolution);
  /// <summary>
  /// Invokes `Unsuspend`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.unsuspend?view=office-pia
  /// </remarks>
  public void Unsuspend();
}
