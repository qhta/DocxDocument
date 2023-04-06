namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph: ElementCollection<IParagraphContent>, IBodyContent, ITableCellContent, ISdtBlockContent
{
  /// <summary>
  ///   Specifies an identifier for a paragraph that is unique within the document part, 
  ///   with the exception that it need not be unique across the choices or fallback of an Alternate Content block. 
  ///   Values MUST be greater than 0 and less than 0x80000000. 
  /// </summary>
  public HexInt? ParagraphId { get; set; }

  /// <summary>
  ///   Specifies a version identifier for a paragraph. Values MUST be greater than 0 and less than 0x80000000. 
  ///   Any element having this attribute MUST also have the <see cref="ParagraphId"/> attribute.
  ///   If two documents have the same docId, then if two paragraphs within the same respective document part 
  ///   that have the same <see cref="ParagraphId"/> and <see cref="TextId"/> SHOULD contain identical text, although formatting could differ. 
  /// </summary>
  public HexInt? TextId { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  public HexInt? RsidParagraphMarkRevision { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  public HexInt? RsidParagraphAddition { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  public HexInt? RsidParagraphDeletion { get; set; }

  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  public HexInt? RsidParagraphProperties { get; set; }

  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  public HexInt? RsidRunAdditionDefault { get; set; }
  
  /// <summary>
  ///   Specifies whether the text of that paragraph is free of detected spelling errors. 
  /// </summary>
  public Boolean? NoSpellError { get; set; }
  
  /// <summary>
  ///   Paragraph Properties.
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