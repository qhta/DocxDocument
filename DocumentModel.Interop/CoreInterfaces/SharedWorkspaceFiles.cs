using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of files in a shared workspace.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacefiles?view=office-pia
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
