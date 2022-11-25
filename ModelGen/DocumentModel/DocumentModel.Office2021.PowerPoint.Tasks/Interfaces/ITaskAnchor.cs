namespace DocumentModel.Office2021.PowerPoint.Tasks;

/// <summary>
/// Defines the TaskAnchor Class.
/// </summary>
public interface ITaskAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// CommentAnchor.
  /// </summary>
  public DocumentModel.Office2021.PowerPoint.Tasks.ICommentAnchor? CommentAnchor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
