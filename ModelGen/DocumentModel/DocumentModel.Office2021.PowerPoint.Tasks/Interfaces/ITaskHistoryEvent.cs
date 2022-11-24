namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
public interface ITaskHistoryEvent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// AtrbtnTaskAssignUnassignUser.
  /// </summary>
  public IAtrbtnTaskAssignUnassignUser? AtrbtnTaskAssignUnassignUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public ITaskAnchor? TaskAnchor { get ; set; }
  
}
