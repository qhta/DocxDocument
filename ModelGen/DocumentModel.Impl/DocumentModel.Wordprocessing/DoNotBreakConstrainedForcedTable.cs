namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Break Table Rows Around Floating Tables.
/// </summary>
public class DoNotBreakConstrainedForcedTable: IDoNotBreakConstrainedForcedTable
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
