namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 6.0 Line Wrapping for East Asian Text.
/// </summary>
public class LineWrapLikeWord6: ILineWrapLikeWord6
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
