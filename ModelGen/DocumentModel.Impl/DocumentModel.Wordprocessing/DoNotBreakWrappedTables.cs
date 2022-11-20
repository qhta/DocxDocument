namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Allow Floating Tables To Break Across Pages.
/// </summary>
public class DoNotBreakWrappedTables: IDoNotBreakWrappedTables
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
