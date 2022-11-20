namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Alternate Set of East Asian Line Breaking Rules.
/// </summary>
public class UseAltKinsokuLineBreakRules: IUseAltKinsokuLineBreakRules
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
