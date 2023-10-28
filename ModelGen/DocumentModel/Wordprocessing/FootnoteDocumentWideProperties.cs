namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document-Wide Footnote Properties.
/// </summary>
public partial class FootnoteDocumentWideProperties
{
  
  /// <summary>
  ///   Footnote Placement.
  /// </summary>
  public DMW.FootnotePositionKind? FootnotePosition { get; set; }
  
  
  /// <summary>
  ///   Footnote Numbering Format.
  /// </summary>
  public DMW.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public UInt16? NumberingStart { get; set; }
  
  
  /// <summary>
  ///   Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public DMW.RestartNumberKind? NumberingRestart { get; set; }
  
}
