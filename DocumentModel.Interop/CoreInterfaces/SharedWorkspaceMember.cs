namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMember` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember?view=office-pia
/// </remarks>
public partial interface SharedWorkspaceMember: InteropObject
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets the `DomainName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.domainname?view=office-pia
  /// </remarks>
  public string DomainName { get; }
  /// <summary>
  /// Gets the `Email` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.email?view=office-pia
  /// </remarks>
  public string Email { get; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemember.id?view=office-pia
  /// </remarks>
  public string Id { get; }
}
