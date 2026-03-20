using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Sync` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync?view=office-pia
/// </remarks>
public partial interface Sync: InteropObject
{
  /// <summary>
  /// Gets the `Status` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.status?view=office-pia
  /// </remarks>
  public MsoSyncStatusType Status { get; }
  /// <summary>
  /// Gets the `WorkspaceLastChangedBy` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.workspacelastchangedby?view=office-pia
  /// </remarks>
  public string WorkspaceLastChangedBy { get; }
  /// <summary>
  /// Gets the `LastSyncTime` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.lastsynctime?view=office-pia
  /// </remarks>
  public object LastSyncTime { get; }
  /// <summary>
  /// Gets the `ErrorType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sync.errortype?view=office-pia
  /// </remarks>
  public MsoSyncErrorType ErrorType { get; }
}
