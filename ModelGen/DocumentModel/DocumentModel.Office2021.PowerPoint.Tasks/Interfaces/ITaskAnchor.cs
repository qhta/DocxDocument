namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2021.PowerPoint.Tasks.ICommentAnchor))]
public interface ITaskAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.ICommentAnchor? CommentAnchor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList? ExtensionList { get ; set; }
  
}
