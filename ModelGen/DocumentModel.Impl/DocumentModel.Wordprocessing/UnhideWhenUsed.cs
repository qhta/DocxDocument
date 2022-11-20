namespace DocumentModel.Wordprocessing;

/// <summary>
/// Remove Semi-Hidden Property When Style Is Used.
/// </summary>
public class UnhideWhenUsed: IUnhideWhenUsed
{
  /// <summary>
  /// val
  /// </summary>
  public OnOffOnlyValues? Val
  {
    get;
    set;
  }
  
}
