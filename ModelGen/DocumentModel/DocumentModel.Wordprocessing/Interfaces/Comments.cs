namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public partial interface Comments
{
  /// <summary>
  /// Gets the WordprocessingCommentsPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.WordprocessingCommentsPart? WordprocessingCommentsPart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Comment>? Items { get; set; }
  
}
