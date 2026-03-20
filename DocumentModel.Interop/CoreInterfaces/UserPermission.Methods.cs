using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `UserPermission` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission?view=office-pia` for Office interop details.
/// </remarks>
public partial interface UserPermission
{
  /// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.remove?view=office-pia
  /// </remarks>
  public void Remove();
}
