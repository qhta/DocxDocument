namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMember` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember?view=office-pia"/>
public partial class SharedWorkspaceMember: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `DomainName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.domainname?view=office-pia"/>
  public string DomainName { get; }
  /// <summary>
  /// Gets the `Email` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.email?view=office-pia"/>
  public string Email { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.id?view=office-pia"/>
  public string Id { get; }


  #region methods

/// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}

