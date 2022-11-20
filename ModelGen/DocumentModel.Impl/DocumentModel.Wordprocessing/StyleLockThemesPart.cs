namespace DocumentModel.Wordprocessing;

/// <summary>
/// Prevent Modification of Themes Part.
/// </summary>
public class StyleLockThemesPart: IStyleLockThemesPart
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
