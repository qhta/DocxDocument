namespace DocumentModel.Spreadsheet;

/// <summary>
/// Comments.
/// </summary>
public interface Comments // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Authors.
  /// </summary>
  public Authors? Authors { get ; set; }
  
  /// <summary>
  /// List of Comments.
  /// </summary>
  public CommentList? CommentList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
