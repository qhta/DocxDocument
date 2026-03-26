namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the priority for a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskpriority?view=office-pia` for Office interop details.
/// </remarks>
public enum SharedWorkspaceTaskPriority
{
  /// <summary>
  /// High priority.
  /// </summary>
  High = 1,
  /// <summary>
  /// Normal priority.
  /// </summary>
  Normal,
  /// <summary>
  /// Low priority.
  /// </summary>
  Low
}
