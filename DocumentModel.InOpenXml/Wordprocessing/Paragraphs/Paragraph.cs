namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a paragraph element in a WordprocessingML document.
/// This interface extends multiple content and collection interfaces, providing properties for unique identification, revision tracking, spell checking, and paragraph formatting. Enables advanced management, revision, and formatting of paragraph content within the document.
/// </summary>
public partial interface Paragraph: IElementCollection<IParagraphContent>,
  IStoryContent, ITableCellContent, ISdtBlockContent, ICustomXmlBlockContent,
  ICommentContent, IBidirectionalContent
{
    
  /// <summary>
  /// Identifier for the paragraph, unique within the document part (except across Alternate Content blocks). Values must be greater than 0 and less than 0x80000000.
  /// </summary>
  public HexInt? ParagraphId { get; set; }
    
  /// <summary>
  /// Version identifier for the paragraph. Values must be greater than 0 and less than 0x80000000. Requires <see cref="ParagraphId"/>. Used for text identity across documents with the same docId.
  /// </summary>
  public HexInt? TextId { get; set; }
    
  /// <summary>
  /// Revision identifier for paragraph glyph formatting.
  /// </summary>
  public HexInt? RsidParagraphMarkRevision { get; set; }
    
  /// <summary>
  /// Revision identifier for paragraph addition.
  /// </summary>
  public HexInt? RsidParagraphAddition { get; set; }
    
  /// <summary>
  /// Revision identifier for paragraph deletion.
  /// </summary>
  public HexInt? RsidParagraphDeletion { get; set; }
    
  /// <summary>
  /// Revision identifier for paragraph properties.
  /// </summary>
  public HexInt? RsidParagraphProperties { get; set; }
    
  /// <summary>
  /// Default revision identifier for runs within the paragraph.
  /// </summary>
  public HexInt? RsidRunAdditionDefault { get; set; }
    
  /// <summary>
  /// Indicates whether the text of the paragraph is free of detected spelling errors.
  /// </summary>
  public bool? NoSpellError { get; set; }
    
  /// <summary>
  /// Paragraph properties, specifying formatting and layout options for the paragraph.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
}