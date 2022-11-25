namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentRelationship Class.
/// </summary>
public interface ICommentRelationship // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
}
