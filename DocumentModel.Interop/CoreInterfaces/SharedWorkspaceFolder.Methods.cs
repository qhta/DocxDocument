using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a folder in a shared workspace.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia"/>
public partial interface SharedWorkspaceFolder
{
  /// <summary>
  /// Deletes the shared workspace folder.
  /// </summary>
  /// <param name="DeleteEventIfFolderContainsFiles">Whether to delete even if the folder contains files.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.delete?view=office-pia"/>
  public void Delete(object DeleteEventIfFolderContainsFiles);
}

