namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Query Cache.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IQuery))]
public class QueryCache: IQueryCache
{
  /// <summary>
  /// Cached Query Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
