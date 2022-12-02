namespace DocumentModel.Spreadsheet;

/// <summary>
/// List of Comments.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IComment>? Comments { get ; set; }
  
}
