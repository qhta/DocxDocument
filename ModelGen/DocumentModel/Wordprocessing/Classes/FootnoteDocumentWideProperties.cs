namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public partial class FootnoteDocumentWideProperties
{
  
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.FootnotePositionValues? FootnotePosition { get; set; }
  
  
  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public DocumentModel.Wordprocessing.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public DocumentModel.Wordprocessing.RestartNumberValues? NumberingRestart { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Wordprocessing.FootnoteEndnoteSeparatorReferenceType>? Items { get; set; }
  
}
