using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceTask` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask?view=office-pia` for Office interop details.
/// </remarks>
public partial class SharedWorkspaceTask
{
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.save?view=office-pia"/>
  public void Save() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetask.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
}

