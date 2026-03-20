using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFiles` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFiles
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="ParentFolder">The `ParentFolder` parameter.</param>
  /// <param name="OverwriteIfFileAlreadyExists">The `OverwriteIfFileAlreadyExists` parameter.</param>
  /// <param name="KeepInSync">The `KeepInSync` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.add?view=office-pia
  /// </remarks>
  public SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
}
