using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Sync` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia"/>
public partial class Sync: InteropObject
{
  /// <summary>
  /// Gets the `Status` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.status?view=office-pia"/>
  public SyncStatusType Status { get; }
  /// <summary>
  /// Gets the `WorkspaceLastChangedBy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.workspacelastchangedby?view=office-pia"/>
  public string WorkspaceLastChangedBy { get; }
  /// <summary>
  /// Gets the `LastSyncTime` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.lastsynctime?view=office-pia"/>
  public object LastSyncTime { get; }
  /// <summary>
  /// Gets the `ErrorType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.errortype?view=office-pia"/>
  public SyncErrorType ErrorType { get; }


  #region methods

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
  /// <param name="syncVersionType">The `SyncVersionType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.openversion?view=office-pia"/>
  public void OpenVersion(SyncVersionType syncVersionType) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ResolveConflict`.
  /// </summary>
  /// <param name="syncConflictResolution">The `SyncConflictResolution` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.resolveconflict?view=office-pia"/>
  public void ResolveConflict(SyncConflictResolutionType syncConflictResolution) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Unsuspend`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.unsuspend?view=office-pia"/>
  public void Unsuspend() { throw new NotImplementedException(); }

  #endregion methods
}

