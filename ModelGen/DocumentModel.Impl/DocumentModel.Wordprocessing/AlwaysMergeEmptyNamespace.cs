namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Mark Custom XML Elements With No Namespace As Invalid.
/// </summary>
public class AlwaysMergeEmptyNamespace: IAlwaysMergeEmptyNamespace
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
