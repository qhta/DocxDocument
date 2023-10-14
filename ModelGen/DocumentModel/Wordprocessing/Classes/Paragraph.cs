namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a paragraph of content in the document.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  public DM.HexBinary? RsidParagraphMarkRevision { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  public DM.HexBinary? RsidParagraphAddition { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  public DM.HexBinary? RsidParagraphDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  public DM.HexBinary? RsidParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  public DM.HexBinary? RsidRunAdditionDefault { get; set; }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? ParagraphId { get; set; }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  public DM.HexBinary? TextId { get; set; }
  
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoSpellError { get; set; }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
