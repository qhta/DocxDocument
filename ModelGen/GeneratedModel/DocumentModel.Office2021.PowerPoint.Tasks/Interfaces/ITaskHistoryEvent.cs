namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IAddEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IUnasgnAllEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IAtrbtnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IAsgnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IUnAsgnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskPriorityRecord))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskProgressEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskScheduleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskTitleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskUndo))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskUnknownRecord))]
public interface ITaskHistoryEvent // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// time, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? Time { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// AtrbtnTaskAssignUnassignUser.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.IAtrbtnTaskAssignUnassignUser? AtrbtnTaskAssignUnassignUser { get ; set; }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.ITaskAnchor? TaskAnchor { get ; set; }
  
}
