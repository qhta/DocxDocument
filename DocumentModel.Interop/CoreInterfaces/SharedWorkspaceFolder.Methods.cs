using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFolder` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFolder
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="DeleteEventIfFolderContainsFiles">The `DeleteEventIfFolderContainsFiles` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.delete?view=office-pia
  /// </remarks>
  public void Delete(object DeleteEventIfFolderContainsFiles);
}
