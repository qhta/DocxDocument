using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceLinks` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia"/>
public partial class SharedWorkspaceLinks: InteropCollection<SharedWorkspaceLink>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="uRL">The `URL` parameter.</param>
  /// <param name="description">The `Description` parameter.</param>
  /// <param name="notes">The `Notes` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.add?view=office-pia"/>
  public SharedWorkspaceLink Add(string uRL, object description, object notes) { throw new NotImplementedException(); }

  #endregion methods
}

