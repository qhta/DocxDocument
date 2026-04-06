using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceLinks` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceLinks: IModelObject
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="URL">The `URL` parameter.</param>
  /// <param name="Description">The `Description` parameter.</param>
  /// <param name="Notes">The `Notes` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacelinks.add?view=office-pia"/>
  public ISharedWorkspaceLink Add(string URL, object Description, object Notes);
}

