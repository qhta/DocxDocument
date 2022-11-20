namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentRelationship Class.
/// </summary>
public interface ICommentRelationship // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Id { get ; set; }
  
}
