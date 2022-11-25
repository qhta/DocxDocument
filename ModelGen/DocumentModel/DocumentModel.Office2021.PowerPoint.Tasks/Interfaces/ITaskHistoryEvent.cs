namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public interface ITaskHistoryEvent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public System.DateTime? Time { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// AtrbtnTaskAssignUnassignUser.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.IOpenXmlTaskAssignUnassignUserElement? AtrbtnTaskAssignUnassignUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.ITaskAnchor? TaskAnchor { get ; set; }
  
}
