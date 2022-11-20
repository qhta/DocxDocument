namespace DocumentModel.Wordprocessing;

/// <summary>
/// Always Use Fixed Width for Hangul Characters.
/// </summary>
public class DisplayHangulFixedWidth: IDisplayHangulFixedWidth
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
