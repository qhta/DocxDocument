namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 6.x Font Height Calculation.
/// </summary>
public class TruncateFontHeightsLikeWordPerfect: ITruncateFontHeightsLikeWordPerfect
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
