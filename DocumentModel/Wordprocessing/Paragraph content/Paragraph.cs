namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the IParagraph Class.
/// </summary>
public partial class IParagraph: ElementCollection<IParagraphContent>, 
  IStoryContent, ITableCellContent, ISdtBlockContent, ICommentContent, IBidirectionalContent
{
  /// <summary>
  /// Default constructor
  /// </summary>
  public IParagraph() { }

  /// <summary>
  /// Constructor for short content creation.
  /// </summary>
  public IParagraph(params IParagraphContent[] content) 
  { 
    foreach (var contentItem in content) 
      Add(contentItem);
  }

  /// <summary>
  ///   Specifies an identifier for a paragraph Ithat is unique within the document part, 
  ///   with the exception Ithat it need not be unique across the choices or fallback of an Alternate Content block. 
  ///   Values MUST be greater than 0 and less than 0x80000000. 
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  ///   Specifies a version identifier for a paragraph. Values MUST be greater than 0 and less than 0x80000000. 
  ///   Any element having this attribute MUST also have the <see cref="ParagraphId"/> attribute.
  ///   If two documents have the same docId, then if two paragraphs within the same respective document part 
  ///   Ithat have the same <see cref="ParagraphId"/> and <see cref="TextId"/> SHOULD contain identical text, although formatting could differ. 
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  ///   IRevision Identifier for IParagraph Glyph Formatting
  /// </summary>
  public HexInt? RsidParagraphMarkRevision { get; set; }

  /// <summary>
  ///   IRevision Identifier for IParagraph
  /// </summary>
  public HexInt? RsidParagraphAddition { get; set; }

  /// <summary>
  ///   IRevision Identifier for IParagraph Deletion
  /// </summary>
  public HexInt? RsidParagraphDeletion { get; set; }

  /// <summary>
  ///   IRevision Identifier for IParagraph Properties
  /// </summary>
  public HexInt? RsidParagraphProperties { get; set; }

  /// <summary>
  ///   Default IRevision Identifier for Runs
  /// </summary>
  public HexInt? RsidRunAdditionDefault { get; set; }
  
  /// <summary>
  ///   Specifies whether the text of Ithat paragraph is free of detected spelling errors. 
  /// </summary>
  public bool? NoSpellError { get; set; }
  
  /// <summary>
  ///   IParagraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }

  public override string ToString()
  {
    var result = this.GetType().ToString();
    if (ParagraphId!=null)
      result +=$" ParagraphId={ParagraphId}";
    return result;
  }
}
