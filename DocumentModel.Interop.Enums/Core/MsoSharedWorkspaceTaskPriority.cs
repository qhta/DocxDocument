namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the priority for a shared workspace task.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosharedworkspacetaskpriority?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoSharedWorkspaceTaskPriority))]
public enum SharedWorkspaceTaskPriority
{
  /// <summary>
  /// High priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskPriority.msoSharedWorkspaceTaskPriorityHigh))]
  High = 1,
  /// <summary>
  /// Normal priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskPriority.msoSharedWorkspaceTaskPriorityNormal))]
  Normal,
  /// <summary>
  /// Low priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoSharedWorkspaceTaskPriority.msoSharedWorkspaceTaskPriorityLow))]
  Low
}
