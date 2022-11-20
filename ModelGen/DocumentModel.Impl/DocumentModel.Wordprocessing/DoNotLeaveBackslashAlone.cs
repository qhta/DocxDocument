namespace DocumentModel.Wordprocessing;

/// <summary>
/// Convert Backslash To Yen Sign When Entered.
/// </summary>
public class DoNotLeaveBackslashAlone: IDoNotLeaveBackslashAlone
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
