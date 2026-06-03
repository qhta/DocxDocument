using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia"/>
public interface ISharedWorkspaceFiles: IInteropCollection<ISharedWorkspaceFile>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Adds a file to the shared workspace.
  /// </summary>
  /// <param name="fileName">The file path or name to add.</param>
  /// <param name="parentFolder">The optional parent folder.</param>
  /// <param name="overwriteIfFileAlreadyExists">Whether to overwrite an existing file.</param>
  /// <param name="keepInSync">Whether to keep the file synchronized.</param>
  /// <returns>The added shared workspace file.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.add?view=office-pia"/>
  public ISharedWorkspaceFile Add(string fileName, object parentFolder, object overwriteIfFileAlreadyExists, object keepInSync);

  #endregion methods
}

