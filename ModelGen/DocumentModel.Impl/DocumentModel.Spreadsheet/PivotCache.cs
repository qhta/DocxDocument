namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache.
/// </summary>
public class PivotCache: IPivotCache
{
  /// <summary>
  /// PivotCache Id
  /// </summary>
  public uint? CacheId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
