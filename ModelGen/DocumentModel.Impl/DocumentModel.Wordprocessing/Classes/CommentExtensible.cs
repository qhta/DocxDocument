namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public class CommentExtensibleImpl: ModelElement<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible>, CommentExtensible
{
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
