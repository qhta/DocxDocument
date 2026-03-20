using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceMembers` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceMembers: InteropCollection<SharedWorkspaceMember>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacemembers.itemcountexceeded?view=office-pia
  /// </remarks>
  public bool ItemCountExceeded { get; }
}
