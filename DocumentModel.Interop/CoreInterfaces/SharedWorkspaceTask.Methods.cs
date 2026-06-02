using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceTask` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceTask
{
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.save?view=office-pia"/>
  public void Save();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.delete?view=office-pia"/>
  public void Delete();
}

