namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Paragraph Class.
/// </summary>
public interface IParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Revision Identifier for Paragraph Glyph Formatting
  /// </summary>
  public IHexBinaryValue? RsidParagraphMarkRevision { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Paragraph
  /// </summary>
  public IHexBinaryValue? RsidParagraphAddition { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Paragraph Deletion
  /// </summary>
  public IHexBinaryValue? RsidParagraphDeletion { get ; set; }
  
  /// <summary>
  /// Revision Identifier for Paragraph Properties
  /// </summary>
  public IHexBinaryValue? RsidParagraphProperties { get ; set; }
  
  /// <summary>
  /// Default Revision Identifier for Runs
  /// </summary>
  public IHexBinaryValue? RsidRunAdditionDefault { get ; set; }
  
  /// <summary>
  /// paraId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? ParagraphId { get ; set; }
  
  /// <summary>
  /// textId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? TextId { get ; set; }
  
  /// <summary>
  /// noSpellErr, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NoSpellError { get ; set; }
  
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public IParagraphProperties? ParagraphProperties { get ; set; }
  
}
