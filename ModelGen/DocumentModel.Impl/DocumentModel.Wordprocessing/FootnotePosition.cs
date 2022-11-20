namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Placement.
/// </summary>
public class FootnotePosition: IFootnotePosition
{
  /// <summary>
  /// Footnote Position Type
  /// </summary>
  public FootnotePositionValues? Val
  {
    get;
    set;
  }
  
}
