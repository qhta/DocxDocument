using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SharedWorkspaceTasks` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.sharedworkspacetasks?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SharedWorkspaceTasks
{
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
  public SharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);
}

