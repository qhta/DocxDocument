using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `UserPermission` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission?view=office-pia"/>
public partial class UserPermission: InteropObject
{
  /// <summary>
  /// Gets the `UserId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.userid?view=office-pia"/>
  public string UserId { get; }
  /// <summary>
  /// Gets or sets the `Permission` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.permission?view=office-pia"/>
  public int Permission { get; set; }
  /// <summary>
  /// Gets or sets the `ExpirationDate` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.expirationdate?view=office-pia"/>
  public object ExpirationDate { get; set; }


  #region methods

/// <summary>
  /// Invokes `Remove`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.userpermission.remove?view=office-pia"/>
  public void Remove() { throw new NotImplementedException(); }

  #endregion methods
}

