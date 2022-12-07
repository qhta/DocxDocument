namespace DocumentModel;

/// <summary>
/// Defines the Task Class.
/// </summary>
public interface Task
{
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public TaskAnchor? TaskAnchor { get ; set; }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public TaskHistory? TaskHistory { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
