namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentRelationship Class.
/// </summary>
public interface ICommentRelationship // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get ; set; }
  
}
