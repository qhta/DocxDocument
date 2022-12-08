namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Text Run.
/// </summary>
public class RunImpl: ModelElementImpl, Run
{
  public DocumentFormat.OpenXml.Wordprocessing.Run? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Run?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Revision Identifier for Run Properties
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision Identifier for Run Deletion
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunDeletion
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision Identifier for Run
  /// </summary>
  public DocumentModel.HexBinaryValue? RsidRunAddition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
  public Collection<Break>? Breaks
  {
    get;
    set;
  }
  
  public Collection<TextType>? Texts
  {
    get;
    set;
  }
  
  public Collection<TextType>? DeletedTexts
  {
    get;
    set;
  }
  
  public Collection<TextType>? FieldCodes
  {
    get;
    set;
  }
  
  public Collection<TextType>? DeletedFieldCodes
  {
    get;
    set;
  }
  
  public Collection<Boolean>? NoBreakHyphens
  {
    get;
    set;
  }
  
  public Collection<Boolean>? SoftHyphens
  {
    get;
    set;
  }
  
  public Collection<Boolean>? DayShorts
  {
    get;
    set;
  }
  
  public Collection<Boolean>? MonthShorts
  {
    get;
    set;
  }
  
  public Collection<Boolean>? YearShorts
  {
    get;
    set;
  }
  
  public Collection<Boolean>? DayLongs
  {
    get;
    set;
  }
  
  public Collection<Boolean>? MonthLongs
  {
    get;
    set;
  }
  
  public Collection<Boolean>? YearLongs
  {
    get;
    set;
  }
  
  public Collection<Boolean>? AnnotationReferenceMarks
  {
    get;
    set;
  }
  
  public Collection<Boolean>? FootnoteReferenceMarks
  {
    get;
    set;
  }
  
  public Collection<Boolean>? EndnoteReferenceMarks
  {
    get;
    set;
  }
  
  public Collection<Boolean>? SeparatorMarks
  {
    get;
    set;
  }
  
  public Collection<Boolean>? ContinuationSeparatorMarks
  {
    get;
    set;
  }
  
  public Collection<SymbolChar>? SymbolChars
  {
    get;
    set;
  }
  
  public Collection<Boolean>? PageNumbers
  {
    get;
    set;
  }
  
  public Collection<Boolean>? CarriageReturns
  {
    get;
    set;
  }
  
  public Collection<Boolean>? TabChars
  {
    get;
    set;
  }
  
  public Collection<EmbeddedObject>? EmbeddedObjects
  {
    get;
    set;
  }
  
  public Collection<Picture>? Pictures
  {
    get;
    set;
  }
  
  public Collection<FieldChar>? FieldChars
  {
    get;
    set;
  }
  
  public Collection<Ruby>? Rubies
  {
    get;
    set;
  }
  
  public Collection<FootnoteEndnoteReferenceType>? FootnoteReferences
  {
    get;
    set;
  }
  
  public Collection<FootnoteEndnoteReferenceType>? EndnoteReferences
  {
    get;
    set;
  }
  
  public Collection<MarkupType>? CommentReferences
  {
    get;
    set;
  }
  
  public Collection<Drawing>? Drawings
  {
    get;
    set;
  }
  
  public Collection<PositionalTab>? PositionalTabs
  {
    get;
    set;
  }
  
  public Collection<Boolean>? LastRenderedPageBreaks
  {
    get;
    set;
  }
  
}
