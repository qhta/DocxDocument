namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public partial class Run
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Math.RunProperties? MathRunProperties { get; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.Wordprocessing.Break? Break { get; set; }
  
  public DocumentModel.Wordprocessing.TextType? Text { get; set; }
  
  public DocumentModel.Wordprocessing.TextType? DeletedText { get; set; }
  
  public DocumentModel.Wordprocessing.TextType? FieldCode { get; set; }
  
  public DocumentModel.Wordprocessing.TextType? DeletedFieldCode { get; set; }
  
  public Boolean? NoBreakHyphen { get; set; }
  
  public Boolean? SoftHyphen { get; set; }
  
  public Boolean? DayShort { get; set; }
  
  public Boolean? MonthShort { get; set; }
  
  public Boolean? YearShort { get; set; }
  
  public Boolean? DayLong { get; set; }
  
  public Boolean? MonthLong { get; set; }
  
  public Boolean? YearLong { get; set; }
  
  public Boolean? AnnotationReferenceMark { get; set; }
  
  public Boolean? FootnoteReferenceMark { get; set; }
  
  public Boolean? EndnoteReferenceMark { get; set; }
  
  public Boolean? SeparatorMark { get; set; }
  
  public Boolean? ContinuationSeparatorMark { get; set; }
  
  public DocumentModel.Wordprocessing.SymbolChar? SymbolChar { get; set; }
  
  public Boolean? PageNumber { get; set; }
  
  public Boolean? CarriageReturn { get; set; }
  
  public Boolean? TabChar { get; set; }
  
  public DocumentModel.Wordprocessing.EmbeddedObject? EmbeddedObject { get; set; }
  
  public DocumentModel.Wordprocessing.Picture? Picture { get; set; }
  
  public DocumentModel.Wordprocessing.FieldChar? FieldChar { get; set; }
  
  public DocumentModel.Wordprocessing.Ruby? Ruby { get; set; }
  
  public DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? FootnoteReference { get; set; }
  
  public DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType? EndnoteReference { get; set; }
  
  public DocumentModel.Wordprocessing.MarkupType? CommentReference { get; set; }
  
  public DocumentModel.Wordprocessing.Drawing? Drawing { get; set; }
  
  public DocumentModel.Wordprocessing.PositionalTab? PositionalTab { get; set; }
  
  public Boolean? LastRenderedPageBreak { get; set; }
  
}
