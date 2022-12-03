namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Query Cache.
/// </summary>
public interface QueryCache // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Cached Query Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<Query>? Queries { get ; set; }
  
}
