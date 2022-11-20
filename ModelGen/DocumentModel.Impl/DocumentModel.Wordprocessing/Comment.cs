namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAltChunk))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICustomXmlBlock))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IBookmarkEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICommentRangeEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IParagraph))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermEnd))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPermStart))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IProofError))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtBlock))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ITable))]
public class Comment: IComment
{
  /// <summary>
  /// initials
  /// </summary>
  public string? Initials
  {
    get;
    set;
  }
  
  /// <summary>
  /// author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
