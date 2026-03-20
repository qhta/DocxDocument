using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `UserPermission` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission?view=office-pia` for Office interop details.
/// </remarks>
public partial interface UserPermission: InteropObject
{
  /// <summary>
  /// Gets or sets the `UserId` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.userid?view=office-pia
  /// </remarks>
  public string UserId { get; }
  /// <summary>
  /// Gets or sets the `Permission` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.permission?view=office-pia
  /// </remarks>
  public int Permission { get; set; }
  /// <summary>
  /// Gets or sets the `ExpirationDate` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.expirationdate?view=office-pia
  /// </remarks>
  public object ExpirationDate { get; set; }
}
