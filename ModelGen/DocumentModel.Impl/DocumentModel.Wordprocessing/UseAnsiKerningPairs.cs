namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use ANSI Kerning Pairs from Fonts.
/// </summary>
public class UseAnsiKerningPairs: IUseAnsiKerningPairs
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
