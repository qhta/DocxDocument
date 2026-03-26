namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the status of a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskstatus?view=office-pia` for Office interop details.
/// </remarks>
public enum SharedWorkspaceTaskStatus
{
  /// <summary>
  /// Not started.
  /// </summary>
  NotStarted = 1,
  /// <summary>
  /// In progress.
  /// </summary>
  InProgress,
  /// <summary>
  /// Completed.
  /// </summary>
  Completed,
  /// <summary>
  /// Deferred.
  /// </summary>
  Deferred,
  /// <summary>
  /// Waiting.
  /// </summary>
  Waiting
}
