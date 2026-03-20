using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFolder` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFolder: InteropObject
{
  /// <summary>
  /// Gets the `FolderName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefolder.foldername?view=office-pia
  /// </remarks>
  public string FolderName { get; }
}
