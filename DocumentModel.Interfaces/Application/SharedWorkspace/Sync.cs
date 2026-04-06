using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `Sync` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia"/>
public partial interface ISync: IModelObject
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
}

