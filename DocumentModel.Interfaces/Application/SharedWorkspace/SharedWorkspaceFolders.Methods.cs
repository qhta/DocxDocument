using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceFolders` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceFolders: IModelObject
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="FolderName">The `FolderName` parameter.</param>
  /// <param name="ParentFolder">The `ParentFolder` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.add?view=office-pia"/>
  public ISharedWorkspaceFolder Add(string FolderName, object ParentFolder);
}

