namespace DocumentModel.Wordprocessing;

/// <summary>
/// Automatically Hyphenate Document Contents When Displayed.
/// </summary>
public class AutoHyphenation: IAutoHyphenation
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
