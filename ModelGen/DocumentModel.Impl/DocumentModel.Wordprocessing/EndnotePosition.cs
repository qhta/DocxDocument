namespace DocumentModel.Wordprocessing;

/// <summary>
/// Endnote Placement.
/// </summary>
public class EndnotePosition: IEndnotePosition
{
  /// <summary>
  /// Endnote Position Type
  /// </summary>
  public EndnotePositionValues? Val
  {
    get;
    set;
  }
  
}
