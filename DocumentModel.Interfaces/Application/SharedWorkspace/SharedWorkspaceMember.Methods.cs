using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceMember` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceMember: IModelObject
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.delete?view=office-pia"/>
  public void Delete();
}

