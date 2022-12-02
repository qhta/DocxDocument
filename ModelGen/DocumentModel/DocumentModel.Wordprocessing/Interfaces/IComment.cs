namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
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
  
  public Collection<IAltChunk>? AltChunks { get ; set; }
  
  public Collection<ICustomXmlBlock>? CustomXmlBlocks { get ; set; }
  
  public Collection<ISdtBlock>? SdtBlocks { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
  public Collection<ITable>? Tables { get ; set; }
  
  public Collection<IProofError>? ProofErrors { get ; set; }
  
  public Collection<IPermStart>? PermStarts { get ; set; }
  
  public Collection<IPermEnd>? PermEnds { get ; set; }
  
  public Collection<IBookmarkStart>? BookmarkStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? BookmarkEnds { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeStarts { get ; set; }
  
  public Collection<IMarkupRangeType>? CommentRangeEnds { get ; set; }
  
}
