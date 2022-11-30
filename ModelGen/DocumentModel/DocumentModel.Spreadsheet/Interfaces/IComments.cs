namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comments.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Authors.
  /// </summary>
  public DocumentModel.Spreadsheet.IAuthors? Authors { get ; set; }
  
  /// <summary>
  /// List of Comments.
  /// </summary>
  public DocumentModel.Spreadsheet.ICommentList? CommentList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
