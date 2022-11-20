namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 6.x/95/97 Footnote Placement.
/// </summary>
public class FootnoteLayoutLikeWord8: IFootnoteLayoutLikeWord8
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
