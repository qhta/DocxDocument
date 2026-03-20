using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Permission` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Permission
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="UserId">The `UserId` parameter.</param>
  /// <param name="Permission">The `Permission` parameter.</param>
  /// <param name="ExpirationDate">The `ExpirationDate` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.add?view=office-pia
  /// </remarks>
  public UserPermission Add(string UserId, object Permission, object ExpirationDate);
  /// <summary>
  /// Invokes `ApplyPolicy`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.applypolicy?view=office-pia
  /// </remarks>
  public void ApplyPolicy(string FileName);
  /// <summary>
  /// Invokes `RemoveAll`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.removeall?view=office-pia
  /// </remarks>
  public void RemoveAll();
}
