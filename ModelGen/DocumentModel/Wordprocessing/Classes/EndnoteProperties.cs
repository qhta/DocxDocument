namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EndnoteProperties Class.
/// </summary>
public partial class EndnoteProperties
{
  
  /// <summary>
  ///   Endnote Placement.
  /// </summary>
  public DocumentModel.Wordprocessing.EndnotePositionValues? EndnotePosition { get; set; }
  
  
  /// <summary>
  ///   Endnote Numbering Format.
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
