namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Grouping Properties.
/// </summary>
public interface IRangeProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Source Data Set Beginning Range
  /// </summary>
  public bool? AutoStart { get ; set; }
  
  /// <summary>
  /// Source Data Ending Range
  /// </summary>
  public bool? AutoEnd { get ; set; }
  
  /// <summary>
  /// Group By
  /// </summary>
  public GroupBy? GroupBy { get ; set; }
  
  /// <summary>
  /// Numeric Grouping Start Value
  /// </summary>
  public double? StartNumber { get ; set; }
  
  /// <summary>
  /// Numeric Grouping End Value
  /// </summary>
  public double? EndNum { get ; set; }
  
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
  public double? GroupInterval { get ; set; }
  
}
