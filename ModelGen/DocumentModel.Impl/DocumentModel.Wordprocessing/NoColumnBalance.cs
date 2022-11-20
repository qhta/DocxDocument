namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Balance Text Columns within a Section.
/// </summary>
public class NoColumnBalance: INoColumnBalance
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
