using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SharedWorkspaceTasks` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISharedWorkspaceTasks: IModelCollection<ISharedWorkspaceTask>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }
}

