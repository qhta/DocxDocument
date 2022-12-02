namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentList Class.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IComment>? Comments { get ; set; }
  
}
