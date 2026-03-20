using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceFiles` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceFiles: InteropCollection<SharedWorkspaceFile>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles.itemcountexceeded?view=office-pia
  /// </remarks>
  public bool ItemCountExceeded { get; }
}
