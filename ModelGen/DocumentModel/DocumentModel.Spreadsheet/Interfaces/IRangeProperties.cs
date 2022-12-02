namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Grouping Properties.
/// </summary>
public interface IRangeProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Source Data Set Beginning Range
  /// </summary>
  public Boolean? AutoStart { get ; set; }
  
  /// <summary>
  /// Source Data Ending Range
  /// </summary>
  public Boolean? AutoEnd { get ; set; }
  
  /// <summary>
  /// Group By
  /// </summary>
  public GroupByKind? GroupBy { get ; set; }
  
  /// <summary>
  /// Numeric Grouping Start Value
  /// </summary>
  public Double? StartNumber { get ; set; }
  
  /// <summary>
  /// Numeric Grouping End Value
  /// </summary>
  public Double? EndNum { get ; set; }
  
  /// <summary>
  /// Date Grouping Start Value
  /// </summary>
  public DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// Date Grouping End Value
  /// </summary>
  public DateTime? EndDate { get ; set; }
  
  /// <summary>
  /// Grouping Interval
  /// </summary>
  public Double? GroupInterval { get ; set; }
  
}
