namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
public interface IEndnoteDocumentWideProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues>? EndnotePosition { get ; set; }
  
  /// <summary>
  /// Endnote Numbering Format.
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
