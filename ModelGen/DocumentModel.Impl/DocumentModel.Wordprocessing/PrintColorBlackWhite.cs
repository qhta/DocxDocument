namespace DocumentModel.Wordprocessing;

/// <summary>
/// Print Colors as Black And White without Dithering.
/// </summary>
public class PrintColorBlackWhite: IPrintColorBlackWhite
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
