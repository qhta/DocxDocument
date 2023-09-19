namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a paragraph of content in the document.
/// </summary>
public partial class Paragraph
{
  
  /// <summary>
  ///   Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  [SchemaAttr("w:rsidRPr")]
  public DocumentModel.HexBinaryValue? RsidParagraphMarkRevision { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph
  /// </summary>
  [SchemaAttr("w:rsidR")]
  public DocumentModel.HexBinaryValue? RsidParagraphAddition { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Deletion
  /// </summary>
  [SchemaAttr("w:rsidDel")]
  public DocumentModel.HexBinaryValue? RsidParagraphDeletion { get; set; }
  
  
  /// <summary>
  ///   Revision Identifier for Paragraph Properties
  /// </summary>
  [SchemaAttr("w:rsidP")]
  public DocumentModel.HexBinaryValue? RsidParagraphProperties { get; set; }
  
  
  /// <summary>
  ///   Default Revision Identifier for Runs
  /// </summary>
  [SchemaAttr("w:rsidRDefault")]
  public DocumentModel.HexBinaryValue? RsidRunAdditionDefault { get; set; }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:paraId")]
  public DocumentModel.HexBinaryValue? ParagraphId { get; set; }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:textId")]
  public DocumentModel.HexBinaryValue? TextId { get; set; }
  
  
  /// <summary>
  ///   noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:noSpellErr")]
  public Boolean? NoSpellError { get; set; }
  
  
  /// <summary>
  ///   Paragraph Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.ParagraphProperties? ParagraphProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
