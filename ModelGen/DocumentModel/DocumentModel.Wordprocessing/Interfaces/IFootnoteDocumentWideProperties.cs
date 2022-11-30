namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public interface IFootnoteDocumentWideProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnotePositionKind? FootnotePosition { get ; set; }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.INumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public System.UInt16? NumberingStart { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public DocumentModel.Wordprocessing.RestartNumberKind? NumberingRestart { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IFootnoteEndnoteSeparatorReferenceType>? FootnoteSpecialReferences { get ; set; }
  
}
