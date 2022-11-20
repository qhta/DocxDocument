namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Legacy Ethiopic and Amharic Line Breaking Rules.
/// </summary>
public class ApplyBreakingRules: IApplyBreakingRules
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
