namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Math.IRunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IBreak? Break { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextType? Text { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextType? DeletedText { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextType? FieldCode { get ; set; }
  
  public DocumentModel.Wordprocessing.ITextType? DeletedFieldCode { get ; set; }
  
  public System.Boolean? NoBreakHyphen { get ; set; }
  
  public System.Boolean? SoftHyphen { get ; set; }
  
  public System.Boolean? DayShort { get ; set; }
  
  public System.Boolean? MonthShort { get ; set; }
  
  public System.Boolean? YearShort { get ; set; }
  
  public System.Boolean? DayLong { get ; set; }
  
  public System.Boolean? MonthLong { get ; set; }
  
  public System.Boolean? YearLong { get ; set; }
  
  public System.Boolean? AnnotationReferenceMark { get ; set; }
  
  public System.Boolean? FootnoteReferenceMark { get ; set; }
  
  public System.Boolean? EndnoteReferenceMark { get ; set; }
  
  public System.Boolean? SeparatorMark { get ; set; }
  
  public System.Boolean? ContinuationSeparatorMark { get ; set; }
  
  public DocumentModel.Wordprocessing.ISymbolChar? SymbolChar { get ; set; }
  
  public System.Boolean? PageNumber { get ; set; }
  
  public System.Boolean? CarriageReturn { get ; set; }
  
  public System.Boolean? TabChar { get ; set; }
  
  public DocumentModel.Wordprocessing.IEmbeddedObject? EmbeddedObject { get ; set; }
  
  public DocumentModel.Wordprocessing.IPicture? Picture { get ; set; }
  
  public DocumentModel.Wordprocessing.IFieldChar? FieldChar { get ; set; }
  
  public DocumentModel.Wordprocessing.IRuby? Ruby { get ; set; }
  
  public DocumentModel.Wordprocessing.IFootnoteEndnoteReferenceType? FootnoteReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IFootnoteEndnoteReferenceType? EndnoteReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IMarkupType? CommentReference { get ; set; }
  
  public DocumentModel.Wordprocessing.IDrawing? Drawing { get ; set; }
  
  public DocumentModel.Wordprocessing.IPositionalTab? PositionalTab { get ; set; }
  
  public System.Boolean? LastRenderedPageBreak { get ; set; }
  
}
