using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files in a shared workspace.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia"/>
public partial class SharedWorkspaceFiles
{
  /// <summary>
  /// Adds a file to the shared workspace.
  /// </summary>
  /// <param name="FileName">The file path or name to add.</param>
  /// <param name="ParentFolder">The optional parent folder.</param>
  /// <param name="OverwriteIfFileAlreadyExists">Whether to overwrite an existing file.</param>
  /// <param name="KeepInSync">Whether to keep the file synchronized.</param>
  /// <returns>The added shared workspace file.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.add?view=office-pia"/>
  public SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync) { throw new NotImplementedException(); }
}

