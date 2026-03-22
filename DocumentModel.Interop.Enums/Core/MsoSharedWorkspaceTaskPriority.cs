namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the priority for a shared workspace task.
/// </summary>
public enum MsoSharedWorkspaceTaskPriority
{
  /// <summary>
  /// High priority.
  /// </summary>
  msoSharedWorkspaceTaskPriorityHigh = 1,
  /// <summary>
  /// Normal priority.
  /// </summary>
  msoSharedWorkspaceTaskPriorityNormal,
  /// <summary>
  /// Low priority.
  /// </summary>
  msoSharedWorkspaceTaskPriorityLow
}
