namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Grouping Properties.
/// </summary>
public interface IRangeProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Source Data Set Beginning Range
  /// </summary>
  public System.Boolean? AutoStart { get ; set; }
  
  /// <summary>
  /// Source Data Ending Range
  /// </summary>
  public System.Boolean? AutoEnd { get ; set; }
  
  /// <summary>
  /// Group By
  /// </summary>
  public DocumentModel.Spreadsheet.GroupByKind? GroupBy { get ; set; }
  
  /// <summary>
  /// Numeric Grouping Start Value
  /// </summary>
  public System.Double? StartNumber { get ; set; }
  
  /// <summary>
  /// Numeric Grouping End Value
  /// </summary>
  public System.Double? EndNum { get ; set; }
  
  /// <summary>
  /// Date Grouping Start Value
  /// </summary>
  public System.DateTime? StartDate { get ; set; }
  
  /// <summary>
  /// Date Grouping End Value
  /// </summary>
  public System.DateTime? EndDate { get ; set; }
  
  /// <summary>
  /// Grouping Interval
  /// </summary>
  public System.Double? GroupInterval { get ; set; }
  
}
