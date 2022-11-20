namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.PowerPoint.Y2021.M06.Main.ICommentAnchor))]
public class TaskAnchor: ITaskAnchor
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.ICommentAnchor? CommentAnchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
