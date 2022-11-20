namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the CacheHierarchy Class.
/// </summary>
public class CacheHierarchy: ICacheHierarchy
{
  /// <summary>
  /// aggregatedColumn, this property is only available in Office 2013 and later.
  /// </summary>
  public int? AggregatedColumn
  {
    get;
    set;
  }
  
}
