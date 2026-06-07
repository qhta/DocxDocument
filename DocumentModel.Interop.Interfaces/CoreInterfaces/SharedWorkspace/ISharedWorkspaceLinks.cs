using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia"/>
public interface ISharedWorkspaceLinks: IInteropCollection<ISharedWorkspaceLink>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="uRL">The `URL` parameter.</param>
  /// <param name="description">The `Description` parameter.</param>
  /// <param name="notes">The `Notes` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.add?view=office-pia"/>
  public ISharedWorkspaceLink Add(string uRL, object description, object notes);

  #endregion methods
}

