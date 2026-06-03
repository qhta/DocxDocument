using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMembers` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers?view=office-pia` for Office interop details.
/// </remarks>
public partial class SharedWorkspaceMembers: InteropCollection<SharedWorkspaceMember>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="email">The `Email` parameter.</param>
  /// <param name="domainName">The `DomainName` parameter.</param>
  /// <param name="displayName">The `DisplayName` parameter.</param>
  /// <param name="role">The `Role` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.add?view=office-pia"/>
  public SharedWorkspaceMember Add(string email, string domainName, string displayName, object role) { throw new NotImplementedException(); }

  #endregion methods
}

