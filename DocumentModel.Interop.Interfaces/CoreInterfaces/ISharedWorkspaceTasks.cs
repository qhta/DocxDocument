using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SharedWorkspaceTasks` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks?view=office-pia` for Office interop details.
/// </remarks>
public interface ISharedWorkspaceTasks: IInteropCollection<ISharedWorkspaceTask>
{
  /// <summary>
  /// Gets the `ItemCountExceeded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks.itemcountexceeded?view=office-pia"/>
  public bool ItemCountExceeded { get; }


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Title">The `Title` parameter.</param>
  /// <param name="Status">The `Status` parameter.</param>
  /// <param name="Priority">The `Priority` parameter.</param>
  /// <param name="Assignee">The `Assignee` parameter.</param>
  /// <param name="Description">The `Description` parameter.</param>
  /// <param name="DueDate">The `DueDate` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks.add?view=office-pia"/>
  public ISharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);

  #endregion methods
}

