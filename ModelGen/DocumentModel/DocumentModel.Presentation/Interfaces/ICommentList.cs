namespace DocumentModel.Presentation;

/// <summary>
/// Comment List.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.IComment>? Comments { get ; set; }
  
}
