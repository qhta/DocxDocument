using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Sync` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia"/>
public partial interface Sync
{
  /// <summary>
  /// Invokes `GetUpdate`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.getupdate?view=office-pia"/>
  public void GetUpdate();
  /// <summary>
  /// Invokes `PutUpdate`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.putupdate?view=office-pia"/>
  public void PutUpdate();
  /// <summary>
  /// Invokes `OpenVersion`.
  /// </summary>
  /// <param name="SyncVersionType">The `SyncVersionType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.openversion?view=office-pia"/>
  public void OpenVersion(SyncVersionType SyncVersionType);
  /// <summary>
  /// Invokes `ResolveConflict`.
  /// </summary>
  /// <param name="SyncConflictResolution">The `SyncConflictResolution` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.resolveconflict?view=office-pia"/>
  public void ResolveConflict(SyncConflictResolutionType SyncConflictResolution);
  /// <summary>
  /// Invokes `Unsuspend`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.unsuspend?view=office-pia"/>
  public void Unsuspend();
}

