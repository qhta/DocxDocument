namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Footnote Properties.
/// </summary>
public partial interface FootnoteDocumentWideProperties
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnotePositionKind? FootnotePosition { get; set; }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingFormat? NumberingFormat { get; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public DocumentModel.Wordprocessing.RestartNumberKind? NumberingRestart { get; set; }
  
  public Collection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? FootnoteSpecialReferences { get; set; }
  
}
