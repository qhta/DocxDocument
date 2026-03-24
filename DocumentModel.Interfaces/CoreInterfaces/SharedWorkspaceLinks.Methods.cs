using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceLinks
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Description">The `Description` parameter.</param>
  /// <param name="Notes">The `Notes` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.add?view=office-pia"/>
  public SharedWorkspaceLink Add(string URL, object Description, object Notes);
}

