namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnoteProperties Class.
/// </summary>
public interface FootnoteProperties
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public FootnotePositionKind? FootnotePosition { get ; set; }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public RestartNumberKind? NumberingRestart { get ; set; }
  
}
