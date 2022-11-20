namespace DocumentModel.Wordprocessing;

/// <summary>
/// First Row of Data Source Contains Column Names.
/// </summary>
public class FirstRowHeader: IFirstRowHeader
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
