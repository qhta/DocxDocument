namespace DocumentModel.Wordprocessing;

/// <summary>
/// Swap Paragraph Borders on Odd Numbered Pages.
/// </summary>
public class SwapBordersFacingPages: ISwapBordersFacingPages
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
