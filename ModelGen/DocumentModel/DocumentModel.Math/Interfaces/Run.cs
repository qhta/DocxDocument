namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public interface Run // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Break>? Breaks { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TextType>? Texts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TextType>? DeletedTexts { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TextType>? FieldCodes { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.TextType>? DeletedFieldCodes { get ; set; }
  
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
  
  public Collection<DocumentModel.Wordprocessing.SymbolChar>? SymbolChars { get ; set; }
  
  public Collection<Boolean>? PageNumbers { get ; set; }
  
  public Collection<Boolean>? CarriageReturns { get ; set; }
  
  public Collection<Boolean>? TabChars { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.EmbeddedObject>? EmbeddedObjects { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Picture>? Pictures { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.FieldChar>? FieldChars { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Ruby>? Rubies { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType>? FootnoteReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.FootnoteEndnoteReferenceType>? EndnoteReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.MarkupType>? CommentReferences { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.Drawing>? Drawings { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.PositionalTab>? PositionalTabs { get ; set; }
  
  public Collection<Boolean>? LastRenderedPageBreaks { get ; set; }
  
}
