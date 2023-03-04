namespace DocumentModel.Wordprocessing;

/// <summary>
///   Comment Content.
/// </summary>
public class Comment
{
  /// <summary>
  ///   initials
  /// </summary>
  public String? Initials { get; set; }

  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  public Collection<AltChunk>? AltChunks { get; set; }

  public CustomXmlBlock? CustomXmlBlock { get; set; }

  public SdtBlock? SdtBlock { get; set; }

  public Collection<Paragraph>? Paragraphs { get; set; }

  public Collection<Table>? Tables { get; set; }

  public ProofError? ProofError { get; set; }

  public PermStart? PermStart { get; set; }

  public PermEnd? PermEnd { get; set; }

  public BookmarkStart? BookmarkStart { get; set; }

  public BookmarkEnd? BookmarkEnd { get; set; }

  public CommentRangeStart? CommentRangeStart { get; set; }

  public CommentRangeEnd? CommentRangeEnd { get; set; }
}