namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Set.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITuples))]
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ISortByTuple))]
public class TupleSet: ITupleSet
{
  /// <summary>
  /// Number of Tuples
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Maximum Rank Requested
  /// </summary>
  public int? MaxRank
  {
    get;
    set;
  }
  
  /// <summary>
  /// MDX Set Definition
  /// </summary>
  public string? SetDefinition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Set Sort Order
  /// </summary>
  public SortValues? SortType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Query Failed
  /// </summary>
  public bool? QueryFailed
  {
    get;
    set;
  }
  
}
