namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 97 East Asian Line Breaking.
/// </summary>
public class UseWord97LineBreakRules: IUseWord97LineBreakRules
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
