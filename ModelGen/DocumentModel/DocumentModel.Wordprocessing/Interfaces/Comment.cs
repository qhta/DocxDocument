namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public interface Comment
{
  /// <summary>
  /// initials
  /// </summary>
  public String? Initials { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
  public Collection<AltChunk>? AltChunks { get ; set; }
  
  public CustomXmlBlock? CustomXmlBlock { get ; set; }
  
  public SdtBlock? SdtBlock { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
  public Collection<Table>? Tables { get ; set; }
  
  public ProofError? ProofError { get ; set; }
  
  public PermStart? PermStart { get ; set; }
  
  public PermEnd? PermEnd { get ; set; }
  
  public BookmarkStart? BookmarkStart { get ; set; }
  
  public MarkupRangeType? BookmarkEnd { get ; set; }
  
  public MarkupRangeType? CommentRangeStart { get ; set; }
  
  public MarkupRangeType? CommentRangeEnd { get ; set; }
  
}
