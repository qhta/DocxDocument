namespace DocumentModel.Wordprocessing;

/// <summary>
/// Use Cached Paragraph Information for Column Balancing.
/// </summary>
public class CachedColumnBalance: ICachedColumnBalance
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
