using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Restricts permissions to the active document and exposes permission settings.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission?view=office-pia"/>
public partial class Permission: InteropCollection<UserPermission>
{
  /// <summary>
  /// Gets or sets the `EnableTrustedBrowser` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.enabletrustedbrowser?view=office-pia"/>
  public bool EnableTrustedBrowser { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.enabled?view=office-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `RequestPermissionURL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.requestpermissionurl?view=office-pia"/>
  public string RequestPermissionURL { get; set; }
  /// <summary>
  /// Gets the `PolicyName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.policyname?view=office-pia"/>
  public string PolicyName { get; }
  /// <summary>
  /// Gets the `PolicyDescription` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.policydescription?view=office-pia"/>
  public string PolicyDescription { get; }
  /// <summary>
  /// Gets or sets the `StoreLicenses` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.storelicenses?view=office-pia"/>
  public bool StoreLicenses { get; set; }
  /// <summary>
  /// Gets or sets the `DocumentAuthor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.documentauthor?view=office-pia"/>
  public string DocumentAuthor { get; set; }
  /// <summary>
  /// Gets the `PermissionFromPolicy` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.permissionfrompolicy?view=office-pia"/>
  public bool PermissionFromPolicy { get; }


  #region methods

/// <summary>
  /// Creates permissions for a specified user.
  /// </summary>
  /// <param name="UserId">The `UserId` parameter.</param>
  /// <param name="Permission">The `Permission` parameter.</param>
  /// <param name="ExpirationDate">The `ExpirationDate` parameter.</param>
  /// <returns>The created user permission.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.add?view=office-pia"/>
  public UserPermission Add(string UserId, object Permission, object ExpirationDate) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a permission policy to the active document.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.applypolicy?view=office-pia"/>
  public void ApplyPolicy(string FileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes all user permissions and disables restrictions.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.permission.removeall?view=office-pia"/>
  public void RemoveAll() { throw new NotImplementedException(); }

  #endregion methods
}

