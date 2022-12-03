namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CacheHierarchy Class.
/// </summary>
public interface CacheHierarchy // : System.Boolean
{
  /// <summary>
  /// aggregatedColumn, this property is only available in Office 2013 and later.
  /// </summary>
  public Int32? AggregatedColumn { get ; set; }
  
}
