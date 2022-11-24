namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the CommentList Class.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Gets the PowerPointCommentPart associated with this element.
  /// </summary>
  public PowerPointCommentPart? PowerPointCommentPart { get ; set; }
  
}
