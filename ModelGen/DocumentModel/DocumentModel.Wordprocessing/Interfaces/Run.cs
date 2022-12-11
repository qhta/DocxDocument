namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public interface Run
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunProperties { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunAddition { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get ; set; }
  
  public Break? Break { get ; set; }
  
  public TextType? Text { get ; set; }
  
  public TextType? DeletedText { get ; set; }
  
  public TextType? FieldCode { get ; set; }
  
  public TextType? DeletedFieldCode { get ; set; }
  
  public Boolean? NoBreakHyphen { get ; set; }
  
  public Boolean? SoftHyphen { get ; set; }
  
  public Boolean? DayShort { get ; set; }
  
  public Boolean? MonthShort { get ; set; }
  
  public Boolean? YearShort { get ; set; }
  
  public Boolean? DayLong { get ; set; }
  
  public Boolean? MonthLong { get ; set; }
  
  public Boolean? YearLong { get ; set; }
  
  public Boolean? AnnotationReferenceMark { get ; set; }
  
  public Boolean? FootnoteReferenceMark { get ; set; }
  
  public Boolean? EndnoteReferenceMark { get ; set; }
  
  public Boolean? SeparatorMark { get ; set; }
  
  public Boolean? ContinuationSeparatorMark { get ; set; }
  
  public SymbolChar? SymbolChar { get ; set; }
  
  public Boolean? PageNumber { get ; set; }
  
  public Boolean? CarriageReturn { get ; set; }
  
  public Boolean? TabChar { get ; set; }
  
  public EmbeddedObject? EmbeddedObject { get ; set; }
  
  public Picture? Picture { get ; set; }
  
  public FieldChar? FieldChar { get ; set; }
  
  public Ruby? Ruby { get ; set; }
  
  public FootnoteEndnoteReferenceType? FootnoteReference { get ; set; }
  
  public FootnoteEndnoteReferenceType? EndnoteReference { get ; set; }
  
  public MarkupType? CommentReference { get ; set; }
  
  public Drawing? Drawing { get ; set; }
  
  public PositionalTab? PositionalTab { get ; set; }
  
  public Boolean? LastRenderedPageBreak { get ; set; }
  
}
