namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate WordPerfect 5.x Line Spacing.
/// </summary>
public class SuppressTopSpacingWordPerfect: ISuppressTopSpacingWordPerfect
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
