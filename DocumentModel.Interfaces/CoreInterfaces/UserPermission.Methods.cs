using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `UserPermission` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission?view=office-pia"/>
public partial interface UserPermission
{
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.remove?view=office-pia"/>
  public void Remove();
}

