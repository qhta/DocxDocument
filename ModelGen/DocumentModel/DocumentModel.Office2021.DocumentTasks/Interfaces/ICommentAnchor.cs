namespace DocumentModel.Office2021.DocumentTasks;

/// <summary>
/// Defines the CommentAnchor Class.
/// </summary>
public interface ICommentAnchor // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
}
