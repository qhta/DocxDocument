namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a paragraph of content in the document.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  public HexBinary? RsidParagraphMarkRevision { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  public HexBinary? RsidParagraphAddition { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  public HexBinary? RsidParagraphDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  public HexBinary? RsidParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  public HexBinary? RsidRunAdditionDefault { get; set; }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexBinary? ParagraphId { get; set; }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexBinary? TextId { get; set; }
  
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoSpellError { get; set; }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  public ParagraphProperties? ParagraphProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
