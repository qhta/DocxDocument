namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document-Wide Endnote Properties.
/// </summary>
public interface IEndnoteDocumentWideProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnotePositionKind? EndnotePosition { get ; set; }
  
  /// <summary>
  /// Endnote Numbering Format.
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
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IFootnoteEndnoteSeparatorReferenceType>? EndnoteSpecialReferences { get ; set; }
  
}
