namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public partial class FootnoteDocumentWideProperties
{
  
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get; set; }
  
  
  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get; set; }
  
  public ElementCollection<FootnoteEndnoteSeparatorReferenceType>? Items { get; set; }
  
}
