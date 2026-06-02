using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Restricts permissions to the active document and exposes permission settings.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission?view=office-pia"/>
public partial interface IPermission
{
  /// <summary>
  /// Creates permissions for a specified user.
  /// </summary>
  /// <param name="UserId">The `UserId` parameter.</param>
  /// <param name="Permission">The `Permission` parameter.</param>
  /// <param name="ExpirationDate">The `ExpirationDate` parameter.</param>
  /// <returns>The created user permission.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.add?view=office-pia"/>
  public UserPermission Add(string UserId, object Permission, object ExpirationDate);
  /// <summary>
  /// Applies a permission policy to the active document.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.applypolicy?view=office-pia"/>
  public void ApplyPolicy(string FileName);
  /// <summary>
  /// Removes all user permissions and disables restrictions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.removeall?view=office-pia"/>
  public void RemoveAll();
}

