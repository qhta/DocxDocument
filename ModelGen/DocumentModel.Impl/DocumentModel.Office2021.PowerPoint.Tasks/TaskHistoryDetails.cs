namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskHistoryDetails Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ITaskHistory))]
public class TaskHistoryDetails: ITaskHistoryDetails
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// TaskHistory.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.ITaskHistory? TaskHistory
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
