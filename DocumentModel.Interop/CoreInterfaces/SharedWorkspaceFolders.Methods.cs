using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFolders` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFolders
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="FolderName">The `FolderName` parameter.</param>
  /// <param name="ParentFolder">The `ParentFolder` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.add?view=office-pia
  /// </remarks>
  public SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
}
