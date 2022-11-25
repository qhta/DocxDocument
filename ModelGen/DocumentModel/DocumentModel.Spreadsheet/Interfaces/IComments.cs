namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comments.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Authors.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Authors { get ; set; }
  
  /// <summary>
  /// List of Comments.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? CommentList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
