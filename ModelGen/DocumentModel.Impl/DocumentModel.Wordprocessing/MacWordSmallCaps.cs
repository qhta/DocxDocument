namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 5.x for the Macintosh Small Caps Formatting.
/// </summary>
public class MacWordSmallCaps: IMacWordSmallCaps
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
