namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comments.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Authors.
  /// </summary>
  public IAuthors? Authors { get ; set; }
  
  /// <summary>
  /// List of Comments.
  /// </summary>
  public ICommentList? CommentList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
