namespace DocumentModel.Spreadsheet;

/// <summary>
/// List of Comments.
/// </summary>
public interface ICommentList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IComment>? Comments { get ; set; }
  
}
