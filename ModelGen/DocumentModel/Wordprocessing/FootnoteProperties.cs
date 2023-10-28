namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteProperties Class.
/// </summary>
public partial class FootnoteProperties
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
