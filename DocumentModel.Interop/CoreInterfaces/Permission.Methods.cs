using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Restricts permissions to the active document and exposes permission settings.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission?view=office-pia
/// </remarks>
public partial interface Permission
{
  /// <summary>
  /// Creates permissions for a specified user.
  /// </summary>
  /// <param name="UserId">The `UserId` parameter.</param>
  /// <param name="Permission">The `Permission` parameter.</param>
  /// <param name="ExpirationDate">The `ExpirationDate` parameter.</param>
  /// <returns>The created user permission.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.add?view=office-pia
  /// </remarks>
  public UserPermission Add(string UserId, object Permission, object ExpirationDate);
  /// <summary>
  /// Applies a permission policy to the active document.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.applypolicy?view=office-pia
  /// </remarks>
  public void ApplyPolicy(string FileName);
  /// <summary>
  /// Removes all user permissions and disables restrictions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.removeall?view=office-pia
  /// </remarks>
  public void RemoveAll();
}
