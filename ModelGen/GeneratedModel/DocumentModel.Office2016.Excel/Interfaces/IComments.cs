namespace DocumentModel.Office2016.Excel;

/// <summary>
/// Represents one comment within a cell..
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IAuthors))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICommentList))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IExtensionList))]
public interface IComments // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Authors.
  /// </summary>
  public IAuthors? Authors { get ; set; }
  
  /// <summary>
  /// List of Comments.
  /// </summary>
  public DocumentModel.Spreadsheet.ICommentList? CommentList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
