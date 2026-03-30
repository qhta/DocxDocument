namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceMember` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember?view=office-pia"/>
public partial interface SharedWorkspaceMember: IModelObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `DomainName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.domainname?view=office-pia"/>
  public string DomainName { get; }
  /// <summary>
  /// Gets the `Email` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.email?view=office-pia"/>
  public string Email { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.id?view=office-pia"/>
  public string Id { get; }
}

