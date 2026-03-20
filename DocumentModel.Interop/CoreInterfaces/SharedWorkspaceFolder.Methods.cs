using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a folder in a shared workspace.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia
/// </remarks>
public partial interface SharedWorkspaceFolder
{
  /// <summary>
  /// Deletes the shared workspace folder.
  /// </summary>
  /// <param name="DeleteEventIfFolderContainsFiles">Whether to delete even if the folder contains files.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.delete?view=office-pia
  /// </remarks>
  public void Delete(object DeleteEventIfFolderContainsFiles);
}
