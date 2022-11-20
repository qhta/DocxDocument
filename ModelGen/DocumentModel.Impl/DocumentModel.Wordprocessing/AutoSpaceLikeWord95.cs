namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 95 Full-Width Character Spacing.
/// </summary>
public class AutoSpaceLikeWord95: IAutoSpaceLikeWord95
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
