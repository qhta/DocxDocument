using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceTasks` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceTasks: InteropCollection<SharedWorkspaceTask>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks.itemcountexceeded?view=office-pia
  /// </remarks>
  public bool ItemCountExceeded { get; }
}
