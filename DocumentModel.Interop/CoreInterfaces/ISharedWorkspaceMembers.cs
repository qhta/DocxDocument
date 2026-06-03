using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMembers` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers?view=office-pia` for Office interop details.
/// </remarks>
public interface ISharedWorkspaceMembers: IInteropCollection<ISharedWorkspaceMember>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.itemcountexceeded?view=office-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.add?view=office-pia"/>
  public ISharedWorkspaceMember Add(string email, string domainName, string displayName, object role);

  #endregion methods
}

