namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IBreak>? Breaks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITextType>? Texts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITextType>? DeletedTexts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITextType>? FieldCodes { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ITextType>? DeletedFieldCodes { get ; set; }
  
  public Collection<Boolean>? NoBreakHyphens { get ; set; }
  
  public Collection<Boolean>? SoftHyphens { get ; set; }
  
  public Collection<Boolean>? DayShorts { get ; set; }
  
  public Collection<Boolean>? MonthShorts { get ; set; }
  
  public Collection<Boolean>? YearShorts { get ; set; }
  
  public Collection<Boolean>? DayLongs { get ; set; }
  
  public Collection<Boolean>? MonthLongs { get ; set; }
  
  public Collection<Boolean>? YearLongs { get ; set; }
  
  public Collection<Boolean>? AnnotationReferenceMarks { get ; set; }
  
  public Collection<Boolean>? FootnoteReferenceMarks { get ; set; }
  
  public Collection<Boolean>? EndnoteReferenceMarks { get ; set; }
  
  public Collection<Boolean>? SeparatorMarks { get ; set; }
  
  public Collection<Boolean>? ContinuationSeparatorMarks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.ISymbolChar>? SymbolChars { get ; set; }
  
  public Collection<Boolean>? PageNumbers { get ; set; }
  
  public Collection<Boolean>? CarriageReturns { get ; set; }
  
  public Collection<Boolean>? TabChars { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IEmbeddedObject>? EmbeddedObjects { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPicture>? Pictures { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IFieldChar>? FieldChars { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IRuby>? Rubies { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IFootnoteEndnoteReferenceType>? FootnoteReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IFootnoteEndnoteReferenceType>? EndnoteReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IMarkupType>? CommentReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IDrawing>? Drawings { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.IPositionalTab>? PositionalTabs { get ; set; }
  
  public Collection<Boolean>? LastRenderedPageBreaks { get ; set; }
  
}
