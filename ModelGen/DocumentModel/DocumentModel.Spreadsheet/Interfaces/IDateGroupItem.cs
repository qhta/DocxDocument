namespace DocumentModel.Spreadsheet;

/// <summary>
/// Date Grouping.
/// </summary>
public interface IDateGroupItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Year
  /// </summary>
  public ushort? Year { get ; set; }
  
  /// <summary>
  /// Month
  /// </summary>
  public ushort? Month { get ; set; }
  
  /// <summary>
  /// Day
  /// </summary>
  public ushort? Day { get ; set; }
  
  /// <summary>
  /// Hour
  /// </summary>
  public ushort? Hour { get ; set; }
  
  /// <summary>
  /// Minute
  /// </summary>
  public ushort? Minute { get ; set; }
  
  /// <summary>
  /// Second
  /// </summary>
  public ushort? Second { get ; set; }
  
  /// <summary>
  /// Date Time Grouping
  /// </summary>
  public DateTimeGroupingValues? DateTimeGrouping { get ; set; }
  
}
