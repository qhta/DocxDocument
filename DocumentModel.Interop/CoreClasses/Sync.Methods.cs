using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Sync` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia"/>
public partial class Sync
{
  /// <summary>
  /// Invokes `GetUpdate`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.getupdate?view=office-pia"/>
  public void GetUpdate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PutUpdate`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.putupdate?view=office-pia"/>
  public void PutUpdate() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `OpenVersion`.
  /// </summary>
  /// <param name="SyncVersionType">The `SyncVersionType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.openversion?view=office-pia"/>
  public void OpenVersion(SyncVersionType SyncVersionType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ResolveConflict`.
  /// </summary>
  /// <param name="SyncConflictResolution">The `SyncConflictResolution` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.resolveconflict?view=office-pia"/>
  public void ResolveConflict(SyncConflictResolutionType SyncConflictResolution) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Unsuspend`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.unsuspend?view=office-pia"/>
  public void Unsuspend() { throw new NotImplementedException(); }
}

