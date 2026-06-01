using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMembers` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers?view=office-pia` for Office interop details.
/// </remarks>
public partial class SharedWorkspaceMembers
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Email">The `Email` parameter.</param>
  /// <param name="DomainName">The `DomainName` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Role">The `Role` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.add?view=office-pia"/>
  public SharedWorkspaceMember Add(string Email, string DomainName, string DisplayName, object Role) { throw new NotImplementedException(); }
}

