using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFolders` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders?view=office-pia` for Office interop details.
/// </remarks>
public interface ISharedWorkspaceFolders: IInteropCollection<ISharedWorkspaceFolder>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="folderName">The `FolderName` parameter.</param>
  /// <param name="parentFolder">The `ParentFolder` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.add?view=office-pia"/>
  public ISharedWorkspaceFolder Add(string folderName, object parentFolder);

  #endregion methods
}

