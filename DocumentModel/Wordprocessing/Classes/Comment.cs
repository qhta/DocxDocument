namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public partial class Comment
{
  /// <summary>
  /// initials
  /// </summary>
  public String? Initials { get; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.AltChunk>? AltChunks { get; set; }
  
  public DocumentModel.Wordprocessing.CustomXmlBlock? CustomXmlBlock { get; set; }
  
  public DocumentModel.Wordprocessing.SdtBlock? SdtBlock { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Paragraph>? Paragraphs { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.Table>? Tables { get; set; }
  
  public DocumentModel.Wordprocessing.ProofError? ProofError { get; set; }
  
  public DocumentModel.Wordprocessing.PermStart? PermStart { get; set; }
  
  public DocumentModel.Wordprocessing.PermEnd? PermEnd { get; set; }
  
  public DocumentModel.Wordprocessing.BookmarkStart? BookmarkStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? BookmarkEnd { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeStart { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupRangeType? CommentRangeEnd { get; set; }
  
}
