namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public interface IFootnoteDocumentWideProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues>? FootnotePosition { get ; set; }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public IUInt16Value? NumberingStart { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues>? NumberingRestart { get ; set; }
  
}
