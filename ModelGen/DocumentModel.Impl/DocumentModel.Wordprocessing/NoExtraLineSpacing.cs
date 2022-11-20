namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Center Content on Lines With Exact Line Height.
/// </summary>
public class NoExtraLineSpacing: INoExtraLineSpacing
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
