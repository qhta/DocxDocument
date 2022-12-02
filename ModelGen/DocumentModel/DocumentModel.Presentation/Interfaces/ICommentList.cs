namespace DocumentModel.Presentation;

/// <summary>
/// Defines the CommentList Class.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IComment>? Comments { get ; set; }
  
}
