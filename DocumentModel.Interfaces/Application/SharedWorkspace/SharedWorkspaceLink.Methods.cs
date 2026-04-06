using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceLink` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceLink: IModelObject
{
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.save?view=office-pia"/>
  public void Save();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelink.delete?view=office-pia"/>
  public void Delete();
}

