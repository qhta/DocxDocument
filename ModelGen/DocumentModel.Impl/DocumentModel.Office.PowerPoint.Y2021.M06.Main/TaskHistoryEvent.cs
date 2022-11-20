namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskHistoryEvent Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IAddEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IUnasgnAllEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskAnchor))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IAtrbtnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IAsgnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IUnAsgnTaskAssignUnassignUser))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskPriorityRecord))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskProgressEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskScheduleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskTitleEventInfo))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskUndo))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskUnknownRecord))]
public class TaskHistoryEvent: ITaskHistoryEvent
{
  /// <summary>
  /// time, this property is only available in Microsoft365 and later.
  /// </summary>
  public DateTime? Time
  {
    get;
    set;
  }
  
  /// <summary>
  /// id, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// AtrbtnTaskAssignUnassignUser.
  /// </summary>
  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.IAtrbtnTaskAssignUnassignUser? AtrbtnTaskAssignUnassignUser
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskAnchor.
  /// </summary>
  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.ITaskAnchor? TaskAnchor
  {
    get;
    set;
  }
  
}
