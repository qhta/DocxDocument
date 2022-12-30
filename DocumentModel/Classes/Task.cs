namespace DocumentModel;

/// <summary>
/// Defines the Task Class.
/// </summary>
public partial class Task
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.TaskAnchor? TaskAnchor { get; set; }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public DocumentModel.TaskHistory? TaskHistory { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.ExtensionList? ExtensionList { get; set; }
  
}
