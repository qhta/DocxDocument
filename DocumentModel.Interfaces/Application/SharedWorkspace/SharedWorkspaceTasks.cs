using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceTasks` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceTasks: IModelCollection<SharedWorkspaceTask>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

