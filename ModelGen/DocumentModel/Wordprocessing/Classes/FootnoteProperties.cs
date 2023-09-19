namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FootnoteProperties Class.
/// </summary>
public partial class FootnoteProperties
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
  
}
