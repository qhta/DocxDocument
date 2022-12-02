namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Grouping.
/// </summary>
public interface IDateGroupItem // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Year
  /// </summary>
  public UInt16? Year { get ; set; }
  
  /// <summary>
  /// Month
  /// </summary>
  public UInt16? Month { get ; set; }
  
  /// <summary>
  /// Day
  /// </summary>
  public UInt16? Day { get ; set; }
  
  /// <summary>
  /// Hour
  /// </summary>
  public UInt16? Hour { get ; set; }
  
  /// <summary>
  /// Minute
  /// </summary>
  public UInt16? Minute { get ; set; }
  
  /// <summary>
  /// Second
  /// </summary>
  public UInt16? Second { get ; set; }
  
  /// <summary>
  /// Date Time Grouping
  /// </summary>
  public DateTimeGroupingKind? DateTimeGrouping { get ; set; }
  
}
