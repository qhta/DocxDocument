namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Hyphenate Words in ALL CAPITAL LETTERS.
/// </summary>
public class DoNotHyphenateCaps: IDoNotHyphenateCaps
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
