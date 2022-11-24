namespace DocumentModel.Presentation;

/// <summary>
/// List of Comment Authors.
/// </summary>
public interface ICommentAuthorList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the CommentAuthorsPart associated with this element.
  /// </summary>
  public CommentAuthorsPart? CommentAuthorsPart { get ; set; }
  
}
