namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the priority for a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskpriority?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSharedWorkspaceTaskPriority")]
public enum SharedWorkspaceTaskPriority
{
  /// <summary>
  /// High priority.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskPriorityHigh")]
  High = 1,
  /// <summary>
  /// Normal priority.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskPriorityNormal")]
  Normal,
  /// <summary>
  /// Low priority.
  /// </summary>
  [InteropEnumValue("msoSharedWorkspaceTaskPriorityLow")]
  Low
}
