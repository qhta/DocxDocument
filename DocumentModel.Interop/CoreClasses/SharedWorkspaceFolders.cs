using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFolders` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders?view=office-pia` for Office interop details.
/// </remarks>
public partial class SharedWorkspaceFolders: InteropCollection<SharedWorkspaceFolder>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="folderName">The `FolderName` parameter.</param>
  /// <param name="parentFolder">The `ParentFolder` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolders.add?view=office-pia"/>
  public SharedWorkspaceFolder Add(string folderName, object parentFolder) { throw new NotImplementedException(); }

  #endregion methods
}

