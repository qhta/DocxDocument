namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunProperties { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  public DocumentModel.IHexBinaryValue? RsidRunAddition { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? RunProperties { get ; set; }
  
  public Collection<IBreak>? Breaks { get ; set; }
  
  public Collection<ITextType>? Texts { get ; set; }
  
  public Collection<ITextType>? DeletedTexts { get ; set; }
  
  public Collection<ITextType>? FieldCodes { get ; set; }
  
  public Collection<ITextType>? DeletedFieldCodes { get ; set; }
  
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
  
  public Collection<ISymbolChar>? SymbolChars { get ; set; }
  
  public Collection<Boolean>? PageNumbers { get ; set; }
  
  public Collection<Boolean>? CarriageReturns { get ; set; }
  
  public Collection<Boolean>? TabChars { get ; set; }
  
  public Collection<IEmbeddedObject>? EmbeddedObjects { get ; set; }
  
  public Collection<IPicture>? Pictures { get ; set; }
  
  public Collection<IFieldChar>? FieldChars { get ; set; }
  
  public Collection<IRuby>? Rubies { get ; set; }
  
  public Collection<IFootnoteEndnoteReferenceType>? FootnoteReferences { get ; set; }
  
  public Collection<IFootnoteEndnoteReferenceType>? EndnoteReferences { get ; set; }
  
  public Collection<IMarkupType>? CommentReferences { get ; set; }
  
  public Collection<IDrawing>? Drawings { get ; set; }
  
  public Collection<IPositionalTab>? PositionalTabs { get ; set; }
  
  public Collection<Boolean>? LastRenderedPageBreaks { get ; set; }
  
}
