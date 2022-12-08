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
  
  public Collection<CustomXmlBlock>? CustomXmlBlocks { get ; set; }
  
  public Collection<SdtBlock>? SdtBlocks { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
  public Collection<Table>? Tables { get ; set; }
  
  public Collection<ProofError>? ProofErrors { get ; set; }
  
  public Collection<PermStart>? PermStarts { get ; set; }
  
  public Collection<PermEnd>? PermEnds { get ; set; }
  
  public Collection<BookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<MarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<MarkupRangeType>? CommentRangeEnds { get ; set; }
  
}
